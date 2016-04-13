using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kviskoteka {
    public partial class InitialForm : Form {

        private Player player1;
        private Player player2;
        private string username;
        private int scoredPoints;
        private bool kvisko;
        private int whichGameKvisko;
        private string sqlConnectionString;
        
        public InitialForm() {
            InitializeComponent();
            player1 = new Player("John Doe");
            player2 = new Player("Jane Doe");
            scoredPoints = 0;
            SqlConnectionString = BuildConnectionString();
        }

        private void rulesButton_Click(object sender, EventArgs e) {
            RulesForm rulesForm = new RulesForm();
            rulesForm.ShowDialog(this);
        }

        public Player Player1 {
            get { return player1; }
        }

        public Player Player2 {
            get { return player2; }
        }

        public string Username {
            get { return username; }
        }

        public int ScoredPoints {
            get { return scoredPoints; }
            set { scoredPoints = value; }
        }

        public bool Kvisko {
            get { return kvisko; }
            set { kvisko = value; }
        }

        public int WhichGameKvisko {
            get { return whichGameKvisko; }
            set { whichGameKvisko = value; }
        }

        public string SqlConnectionString {
            get { return sqlConnectionString; }
            private set { sqlConnectionString = value; }
        }

        private void startTheGameButton_Click(object sender, EventArgs e) {
            UsernameForm usernameForm = new UsernameForm();
            usernameForm.ShowDialog();

            if (usernameForm.DialogResult == DialogResult.OK && usernameForm.UsernameTextbox.Text.Trim() == "") {
                MessageBox.Show("Molimo unesite ime");
            }
           else if (usernameForm.DialogResult == DialogResult.OK) {
                username = usernameForm.UsernameTextbox.Text;
                FirstGameForm firstGameForm = new FirstGameForm(this);
                firstGameForm.Player1NameLabel.Text = player1.Name;
                firstGameForm.Player2NameLabel.Text = player2.Name;
                firstGameForm.UsernameLabel.Text = username;
                firstGameForm.ShowDialog(this);

                //firstGameForm zatvorena - prikazuju se rezultati
                ResultsForm resultsAfterFirstGame = new ResultsForm(1);
                populateFormWithData(resultsAfterFirstGame);
                resultsAfterFirstGame.ShowDialog(this);
            }
        }

        public void populateFormWithData(ResultsForm results)
        {
            if (results.Game == 1) {
                SetDataSpecificForFirstGame(results);
            }
            else if (results.Game == 2) {
                SetDataSpecificForSecondGame(results);
            }
            else {
                SetDataSpecificForFinalGame(results);
            }

            HideUnneededElements(results);
            SetData(results);
        }

        private void SetData(ResultsForm results)
        {
            results.UsernameLabel.Text = username;
            results.UserScoredPointsLabel.Text = scoredPoints.ToString();

            results.Player1NameLabel.Text = player1.Name;
            results.Player1ScoredPointsLabel.Text = player1.ScoredPoints.ToString();

            results.Player2NameLabel.Text = player2.Name;
            results.Player2ScoredPointsLabel.Text = player2.ScoredPoints.ToString();
        }

        private void HideUnneededElements(ResultsForm results)
        {
            if (results.Game != 1) {
                results.ResultsAfterFirstGameTablePanel.ColumnStyles[2].SizeType = SizeType.Absolute;
                results.ResultsAfterFirstGameTablePanel.ColumnStyles[2].Width = 0;
            }

            if (results.Game != 1 || (results.Game == 1 && !kvisko)) {
                results.GroupBoxKvisko.Visible = false;
                results.RadioButtonGame2.Visible = false;
                results.RadioButtonFinalGame.Visible = false;
                results.LabelKviskoWhichGame.Visible = false;
            }
        }

        private void SetDataSpecificForFinalGame(ResultsForm results)
        {
            results.ResultsLabel.Text = "Konačni rezultati su sljedeći:";
            string winner;
            if (ScoredPoints > Player1.ScoredPoints && ScoredPoints > Player2.ScoredPoints)
                winner = Username;
            else if (Player1.ScoredPoints > ScoredPoints && Player1.ScoredPoints > Player2.ScoredPoints)
                winner = Player1.Name;
            else
                winner = Player2.Name;

            results.KviskoBetDecisionLabel.Visible = true;
            results.KviskoBetDecisionLabel.Text = "Pobjednik je " + winner 
                                                + "! Čestitamo. Osvojili ste 20 000 kuna i ljetovanje na Mallorci!";
            results.ButtonContinue.Text = "Kraj";
        }

        private static void SetDataSpecificForSecondGame(ResultsForm results)
        {
            results.ResultsLabel.Text = "Bodovno stanje nakon druge igre je sljedeće";
            results.ButtonContinue.Text = "Krenimo u završnu igru!";
        }

        private void SetDataSpecificForFirstGame(ResultsForm results)
        {
            results.ResultsLabel.Text = "Nakon odigrane prve igre, rezultati su sljedeći:";
            results.ButtonContinue.Text = "Nastavimo s igrom 2!";

            if (kvisko)
                results.PictureBoxUserKvisko.Image = Properties.Resources.kvisko;

            if (player1.Kvisko)
                results.PictureBoxOpponent1Kvisko.Image = Properties.Resources.kvisko;
            
            if (player2.Kvisko)
                results.PictureBoxOpponent2Kvisko.Image = Properties.Resources.kvisko;

        }

        private string BuildConnectionString()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string path = (System.IO.Path.GetDirectoryName(baseDirectory));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\kviskotekaDb.mdf;Integrated Security=True";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form adminForm = new AdminForm(this);
            adminForm.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
