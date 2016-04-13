using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kviskoteka {
    public partial class AddQuestionSubForm : Form {

        private int game;

        public AddQuestionSubForm(int game, Form owner)
        {
            this.game = game;
            this.Owner = owner;
            InitializeComponent();

            if (game == 1) {
                labelAnswer4.Visible = false;
                labelAnswer5.Visible = false;
                textBoxAnswer4.Visible = false;
                textBoxAnswer5.Visible = false;
                labelDescription.Text = "Klikom na kružić desno od odgovora označavate da je taj odgovor točan.";
            }

            else if (game == 3) {
                radioButtonCorrect2.Visible = false;
                radioButtonCorrect3.Visible = false;
                radioButtonCorrect1.Visible = false;
                labelDescription.Text = "Odgovor 1 mora biti točan odgovor, a svi ostali odgovori se smatraju pogrešnima.";
            }
            PopulateTreeViewWithQuestions();
        }

        private void PopulateTreeViewWithQuestions()
        {
            using (SqlConnection connection = new SqlConnection((Owner as InitialForm).SqlConnectionString)) {
                connection.Open();
                using (SqlCommand command = CreateSqlCommand_GetAllQuestions(connection)) {
                    using (SqlDataReader reader = command.ExecuteReader())
                    if (reader.HasRows)
                        while (reader.Read())
                            InsertNode(reader);
                }
            }
        }

        private void InsertNode(SqlDataReader reader)
        {
            treeViewQuestionsAnswers.BeginUpdate();
            string question = reader.GetInt32(0) + ". " + reader.GetString(1);
            TreeNode node = treeViewQuestionsAnswers.Nodes.Add(question);
            for (int i = 2; i <= 6; ++i) {
                if (game != 3 && i > 4)
                    break;
                string answer = String.Format("{0}) {1}", i - 1, reader.GetString(i));
                TreeNode answerNode = new TreeNode(answer);
                node.Nodes.Add(answerNode);
            }
            treeViewQuestionsAnswers.EndUpdate();
        }

        private SqlCommand CreateSqlCommand_GetAllQuestions(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand();
            string gameTable = GetTableName();
            cmd.CommandText = string.Format("SELECT * FROM {0}", gameTable);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            return cmd;
        }

        private string GetTableName()
        {
            if (game == 1)
                return "ABCGame";
            else if (game == 2)
                return "Game2"; // TODO
            else
                return "FinalGame";
        }

        private void buttonClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (SomeFieldIsEmpty()) {
                MessageBox.Show("Niste ispunili sva potrebna polja!");
                return;
            }

            if (CorrectAnswerNotChecked()) {
                MessageBox.Show("Niste označili koji odgovor je točan!");
                return;
            }

            using (SqlConnection connection = new SqlConnection((Owner as InitialForm).SqlConnectionString)) {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@question", textBoxQuestion.Text);

                    if (game == 1) 
                        AddParametersToSqlCommandForABCGame(cmd);

                    else if (game == 2) {
                        //TODO
                    }

                    else
                        AddParametersToSqlCommandForFinalGame(cmd);

                    if (cmd.ExecuteNonQuery() != 1)
                        MessageBox.Show("Greška prilikom dodavanja pitanja. Molimo pokušajte ponovno.");
                    else {
                        MessageBox.Show("Pitanje je uspješno dodano.");
                        treeViewQuestionsAnswers.Nodes.Clear();
                        PopulateTreeViewWithQuestions();
                        ClearFields();
                    }
                }
            }
        }

        private bool CorrectAnswerNotChecked()
        {
            return game == 1 
                    && !radioButtonCorrect1.Checked 
                    && !radioButtonCorrect2.Checked 
                    && !radioButtonCorrect3.Checked;
        }

        private bool SomeFieldIsEmpty()
        {
            return textBoxQuestion.Text.Trim().Length == 0 ||
                    textBoxAnswer1.Text.Trim().Length == 0 ||
                    textBoxAnswer2.Text.Trim().Length == 0 ||
                    textBoxAnswer3.Text.Trim().Length == 0 ||
                    (game == 3 && 
                        (textBoxAnswer4.Text.Trim().Length == 0 || 
                        textBoxAnswer5.Text.Trim().Length == 0));
        }

        private void ClearFields()
        {
            textBoxQuestion.Clear();
            textBoxAnswer1.Clear();
            textBoxAnswer2.Clear();
            textBoxAnswer3.Clear();
            textBoxAnswer4.Clear();
            textBoxAnswer5.Clear();
        }

        private void AddParametersToSqlCommandForFinalGame(SqlCommand cmd)
        {
            cmd.CommandText = "INSERT INTO FinalGame (Question, Answer1, Answer2, Answer3, Answer4, Answer5) " +
                                            "VALUES (@question, @answer1, @answer2, @answer3, @answer4, @answer5)";

            cmd.Parameters.AddWithValue("@answer1", textBoxAnswer1.Text);
            cmd.Parameters.AddWithValue("@answer2", textBoxAnswer2.Text);
            cmd.Parameters.AddWithValue("@answer3", textBoxAnswer3.Text);
            cmd.Parameters.AddWithValue("@answer4", textBoxAnswer4.Text);
            cmd.Parameters.AddWithValue("@answer5", textBoxAnswer5.Text);
        }

        private void AddParametersToSqlCommandForABCGame(SqlCommand cmd)
        {
            cmd.CommandText = "INSERT INTO ABCGame (Question, AnswerA, AnswerB, AnswerC, CorrectAnswer) " +
                                            "VALUES (@question, @answerA, @answerB, @answerC, @correctAnswer)";

            cmd.Parameters.AddWithValue("@answerA", textBoxAnswer1.Text);
            cmd.Parameters.AddWithValue("@answerB", textBoxAnswer2.Text);
            cmd.Parameters.AddWithValue("@answerC", textBoxAnswer3.Text);

            string correctAnswer = GetCorrectAnswer();
            cmd.Parameters.AddWithValue("@correctAnswer", correctAnswer);
        }

        private string GetCorrectAnswer()
        {
            if (radioButtonCorrect1.Checked)
                return textBoxAnswer1.Text;
            else if (radioButtonCorrect2.Checked)
                return textBoxAnswer2.Text;
            else
                return textBoxAnswer3.Text;
        }
    }
}
