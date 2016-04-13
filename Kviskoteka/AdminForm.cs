using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Kviskoteka {
    public partial class AdminForm : Form {

        public AdminForm(Form owner)
        {
            this.Owner = owner;
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // odi u bazu, vidi je l postoji korisnik s danim usernameom, i ako da, je l mu šifra dobra
            using (SqlConnection connection = new SqlConnection((Owner as InitialForm).SqlConnectionString)) 
            {
                connection.Open();
                using (SqlCommand command = CreateCommand_GetUserWithGivenData(connection)) {
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        if (reader.HasRows) {
                            reader.Read();
                            if (HashSHA1(textBoxPassword.Text) == reader.GetString(1)) {
                                LoginSuccessful();
                            }
                            else
                                Warn("Pogrešna lozinka!");
                        }
                        else {
                            Warn("Korisničko ime ne postoji!");
                        }
                    }
                }
            }
        }

        private SqlCommand CreateCommand_GetUserWithGivenData(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT username, password FROM Admin WHERE username = @username";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
            cmd.Connection = conn;
            return cmd;
        }

        private void LoginSuccessful()
        {
            MessageBox.Show("Dobrodošli!");
            this.Close();
            Form form = new AddQuestionMainForm(this.Owner);
            form.ShowDialog();
        }

        private static string HashSHA1(string value)
        {
            var sha1 = SHA1.Create();
            var inputBytes = Encoding.ASCII.GetBytes(value);
            var hash = sha1.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            for (var i = 0; i < hash.Length; i++) {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length < 8)
                Warn("Lozinka treba imati barem 8 znakova!");
            else if (textBoxPassword.Text != textBoxRepeatedPassword.Text)
                Warn("Lozinke se ne poklapaju!");
            else
                TryToInsertUser();
        }

        private void TryToInsertUser()
        {
            using (SqlConnection connection = new SqlConnection((Owner as InitialForm).SqlConnectionString)) {
                connection.Open();
                using (SqlCommand cmd = CreateCommand_CheckIfUsernameExists(connection))
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    if (reader.HasRows) {
                        Warn("Korisničko ime je zauzeto!");
                        textBoxUsername.Clear();
                    }
                    else
                        InsertUser();
                }
            }
        }

        private void InsertUser()
        {
            using (SqlConnection connection = new SqlConnection((Owner as InitialForm).SqlConnectionString)) {
                connection.Open();
                using (SqlCommand cmd = CreateCommand_InsertUser(connection)) {
                    int result = cmd.ExecuteNonQuery();
                    if (result != 1)
                        MessageBox.Show("Greška prilikom dodavanja korisnika. Molimo pokušajte ponovno.");
                    else
                        MessageBox.Show("Korisnik je uspješno dodan.");
                }
            }
        }
        
        private SqlCommand CreateCommand_InsertUser(SqlConnection connection)
        {
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.CommandText = "INSERT INTO Admin (username, password) VALUES (@username, @encryptedPassword)";
            cmdInsert.Parameters.AddWithValue("@username", textBoxUsername.Text);
            cmdInsert.Parameters.AddWithValue("@encryptedPassword", HashSHA1(textBoxPassword.Text));
            cmdInsert.Connection = connection;
            return cmdInsert;
        }

        private SqlCommand CreateCommand_CheckIfUsernameExists(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT username FROM Admin WHERE username = @username";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
            cmd.Connection = conn;
            return cmd;
        }

        private void Warn(string message)
        {
            MessageBox.Show(message);
            textBoxPassword.Clear();
            textBoxRepeatedPassword.Clear();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonLogin.PerformClick();
        }
    }
}
