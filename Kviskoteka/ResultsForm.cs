using System;
using System.Windows.Forms;

namespace Kviskoteka {
    public partial class ResultsForm : Form {
        public ResultsForm(int game) {
            InitializeComponent();
            this.Game = game;
        }

        public TableLayoutPanel ResultsAfterFirstGameTablePanel  {
            get { return resultsAfterFirstGameTablePanel; }
        }

        public Label UsernameLabel {
            get { return usernameLabel; }
        }

        public Label ResultsLabel {
            get { return resultsLabel; }
        }

        public Label UserScoredPointsLabel {
            get { return userScoredPointsLabel; }
        }
        
        public Label Player1NameLabel {
            get { return player1NameLabel; }
        }

        public Label Player1ScoredPointsLabel {
            get { return player1ScoredPointsLabel; }
        }
        
        public Label Player2NameLabel {
            get { return player2NameLabel; }
        }

        public Label Player2ScoredPointsLabel {
            get { return player2ScoredPointsLabel; }
        }

        public Label LabelKviskoWhichGame {
            get { return labelKviskoWhichGame; }
        }
        public Label KviskoBetDecisionLabel {
            get { return kviskoBetDecisionLabel; }
        }

        public GroupBox GroupBoxKvisko {
            get { return groupBoxKvisko; }
        }

        public Button ButtonContinue {
            get { return buttonContinue; }
        }

        public RadioButton RadioButtonGame2 {
            get { return radioButtonGame2; }
        }

        public RadioButton RadioButtonFinalGame {
            get { return radioButtonFinalGame; }
        }

        public PictureBox PictureBoxUserKvisko {
            get { return pictureBoxUserKvisko; }
        }

        public PictureBox PictureBoxOpponent1Kvisko {
            get { return pictureBoxOpponent1Kvisko; }
        }

        public PictureBox PictureBoxOpponent2Kvisko {
            get { return pictureBoxOpponent2Kvisko; }
        }

        public int Game {
            get;
            set;
        }

        private void ResultsAfterFirstGameForm_Load(object sender, EventArgs e) {
            if ((Owner as InitialForm).Player1.Kvisko ||
                (Owner as InitialForm).Player2.Kvisko) {
                    buttonContinue.Enabled = false;
                    playersThinkingTimer.Enabled = true;
                    kviskoBetDecisionLabel.Text = "Igrači razmišljaju u koju igru da ulože kviska...";
                    kviskoBetDecisionLabel.Visible = true;
            }
        }
        
        private void playersThinkingTimer_Tick(object sender, EventArgs e) {
            //treba napraviti da igrači 1 i 2 ulažu kviska s većom vjerojatnosti u onaj
            //kviz koji im bolje leži

            //ako im neka igra ide bolje, onda će u nju uložiti kviska s vjerojatnošću od 75 posto
            //ako su težine na igrama jednake, onda je svejedno (šansa od 50 posto)

            if ((Owner as InitialForm).Player1.Kvisko) {
                SetKviskoForOpponent1();
            }
            if ((Owner as InitialForm).Player2.Kvisko) {
                SetKviskoForOpponent2();
            }
            playersThinkingTimer.Enabled = false;
            buttonContinue.Enabled = true;
        }

        private void SetKviskoForOpponent2()
        {
            //kvisko se ne ulaže u sljedeću igru ako imamo 10 ili više bodova od korisnika
            if ((Owner as InitialForm).Player2.ScoredPoints - (Owner as InitialForm).ScoredPoints > 10) {
                (Owner as InitialForm).Player2.BetKviskoInGame = 3;
                player2KviskoBetDecisionLabel.Text = (Owner as InitialForm).Player2.Name
                                                    + " odlučuje da ulaže kviska u igru sljedeću igru";
            }
            //bolje mu ili jednako ide igra 3
            else {
                player2KviskoBetDecisionLabel.Text = (Owner as InitialForm).Player2.Name
                                                    + " odlučuje ne uložiti kviska zbog velike prednosti pred korisnikom";
                
            }
            player2KviskoBetDecisionLabel.Visible = true;
        }

        private void SetKviskoForOpponent1()
        {
            //kvisko se ne ulaže u sljedeću igru ako imamo 10 ili više bodova od korisnika
            if ((Owner as InitialForm).Player1.ScoredPoints - (Owner as InitialForm).ScoredPoints > 10) {
                (Owner as InitialForm).Player1.BetKviskoInGame = 3;
                player1KviskoBetDecisionLabel.Text = (Owner as InitialForm).Player1.Name
                                                    + " odlučuje da ulaže kviska u igru sljedeću igru";
            }
            //bolje mu ili jednako ide igra 3
            else {
                player1KviskoBetDecisionLabel.Text = (Owner as InitialForm).Player1.Name
                                                    + " odlučuje ne uložiti kviska zbog velike prednosti pred korisnikom";

            }
            player1KviskoBetDecisionLabel.Visible = true;
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if (this.Game == 1) {
                if (radioButtonGame2.Checked)
                    (Owner as InitialForm).WhichGameKvisko = 2;
                else if (radioButtonFinalGame.Checked)
                    (Owner as InitialForm).WhichGameKvisko = 3;
                FinalGameForm finalGame = new FinalGameForm(Owner as InitialForm);
                finalGame.LabelOpponent1.Text = (Owner as InitialForm).Player1.Name;
                finalGame.LabelOpponent2.Text = (Owner as InitialForm).Player2.Name;
                finalGame.LabelPlayer.Text = (Owner as InitialForm).Username;
                finalGame.ShowDialog();
            }
            this.Close();
        }
    }
}

