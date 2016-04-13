using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Kviskoteka {
    public partial class FirstGameForm : Form {

        private int questionId;
        private string correctAnswer;
        private bool allPlayersAnswered = false;
        private int numberOfSecondsPassed = 0;
        private int numberOfQuestionsInDatabase;
        private List<int> questionAlreadyPosted;
        private readonly int MAX_QUESTIONS = 5;
        Random random = new Random();

        public FirstGameForm(Form owner) {
            this.Owner = owner;
            InitializeComponent();
            questionAlreadyPosted = new List<int>();
            numberOfQuestionsInDatabase = 0;
            getNumberOfQuestionsInDatabase();
            getNewQuestion();
        }
        
        private void getNumberOfQuestionsInDatabase()
        {
            using (SqlConnection connection = new SqlConnection((Owner as InitialForm).SqlConnectionString)) {
                connection.Open();
                using (SqlCommand command = new SqlCommand()) {
                    command.CommandText = "SELECT COUNT(*) FROM ABCGame";
                    command.CommandType = CommandType.Text;
                    command.Connection = connection;
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        if (reader.Read())
                            numberOfQuestionsInDatabase = reader.GetInt32(0);
                    }
                }
            }
        }

        private void getNewQuestion() {
            questionId = random.Next(1, numberOfQuestionsInDatabase + 1);
            while (questionAlreadyPosted.Contains(questionId))
                questionId = random.Next(1, numberOfQuestionsInDatabase + 1);

            using (SqlConnection connection = new SqlConnection((Owner as InitialForm).SqlConnectionString)) {
                connection.Open();
                using (SqlCommand command = new SqlCommand()) {
                    command.CommandText = "SELECT * FROM ABCGame WHERE QuestionID=" + questionId.ToString();
                    command.CommandType = CommandType.Text;
                    command.Connection = connection;
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        if (reader.Read())
                            getQuestionData(reader);
                    }
                }
            }
            questionAlreadyPosted.Add(questionId);
            playersGiveAnswersTimer.Enabled = true;
        }

        private void getQuestionData(SqlDataReader reader)
        {
            questionLabel.Text = questionAlreadyPosted.Count + 1 + ". " + reader.GetString(1);
            answerAradioButton.Text = reader.GetString(2);
            answerBRadioButton.Text = reader.GetString(3);
            answerCRadioButton.Text = reader.GetString(4);
            correctAnswer = reader.GetString(5);
        }

        private void answerRadioButton_MouseClick(object sender, MouseEventArgs e)
        {
            disableAnswersThatAreNotClicked();
            for (int column = 0; column < tableLayoutPanel.ColumnCount; ++column) {
                RadioButton answer = tableLayoutPanel.GetControlFromPosition(column, 1) as RadioButton;
                if ((answer.Checked && answer.Text == correctAnswer)) {
                    (Owner as InitialForm).ScoredPoints += 2;
                    userCorrectAnswerBox.BackColor = Color.LightGreen;
                    break;
                }
                if (answer.Checked && answer.Text != correctAnswer) {
                    userCorrectAnswerBox.BackColor = Color.PaleVioletRed;
                    break;
                }
            }

            //moramo čekati da računala odgovore ako odgovorimo prije njih (znamo da su odgovorila ako su im boje kućica zelena ili crvena
            //odgovaraju u isto vrijeme (za sada) pa je dosta za jedno računalo
            if (!Equals(player1CorrectAnswerBox.BackColor, Color.PaleVioletRed) 
                    && !Equals(player1CorrectAnswerBox.BackColor, Color.LightGreen)) {
                Thread.Sleep(2500);
                playersGiveAnswersTimer_Tick(playersGiveAnswersTimer, e);
            }

            allPlayersAnswered = true;
            if (allPlayersAnswered) {
                markCorrectAnswer();
                oneSecondTimer.Enabled = true;
            }
        }

        private void disableAnswersThatAreNotClicked() {
            if (answerAradioButton.Checked) {
                answerBRadioButton.Enabled = false;
                answerCRadioButton.Enabled = false;
            } else if (answerBRadioButton.Checked) {
                answerAradioButton.Enabled = false;
                answerCRadioButton.Enabled = false;
            } else {
                answerAradioButton.Enabled = false;
                answerBRadioButton.Enabled = false;
            }
        }

        private void playersGiveAnswersTimer_Tick(object sender, EventArgs e) {
            //TAKO DA IMAMO NEZAVISNOST (ako je ista težina, želimo da postoji mogućnost da jedan točno odgovori, drugi netočno
            int randomNumber1 = random.Next(0, 101);
            int randomNumber2 = random.Next(0, 101);

            double difficulty1 = (Owner as InitialForm).Player1.Game1Difficulty;
            double difficulty2 = (Owner as InitialForm).Player2.Game1Difficulty;

            if (randomNumber1 > difficulty1) {
                player1CorrectAnswerBox.BackColor = Color.PaleVioletRed;
            } else {
                player1CorrectAnswerBox.BackColor = Color.LightGreen;
                (Owner as InitialForm).Player1.ScoredPoints += 2;
            }

            if (randomNumber2 > difficulty2) {
                player2CorrectAnswerBox.BackColor = Color.PaleVioletRed;
            } else {
                player2CorrectAnswerBox.BackColor = Color.LightGreen;
                (Owner as InitialForm).Player2.ScoredPoints += 2;
            }

            playersGiveAnswersTimer.Enabled = false;
        }

        private void markCorrectAnswer() {
            for (int column = 0; column < tableLayoutPanel.ColumnCount; ++column) {
                Control answer = tableLayoutPanel.GetControlFromPosition(column, 1);
                if (answer.Text == correctAnswer) {
                    answer.BackColor = Color.LightGreen;
                }
            }
        }

        private void oneSecondTimer_Tick(object sender, EventArgs e) {
            if (MAX_QUESTIONS == questionAlreadyPosted.Count()) {
                oneSecondTimer.Enabled = false;
                numberOfSecondsPassed = 0;
                checkWhoGetsKvisko();
                MessageBox.Show("Odgovorili ste na sva pitanja prve igre!\nPogledajmo rezultate.");
                this.Close();
            } else {
                numberOfSecondsPassed += 1;
                newQuestionCountDownLabel.Text = "Novo pitanje za: " + (4 - numberOfSecondsPassed).ToString();
                if (numberOfSecondsPassed == 4) {
                    resetForm();
                    oneSecondTimer.Enabled = false;
                    numberOfSecondsPassed = 0;
                    getNewQuestion();
                }
            }
        }

        private void checkWhoGetsKvisko() {
            int neededMinimumForKvisko = (int)  (0.75 * MAX_QUESTIONS * 2);
            if ((Owner as InitialForm).ScoredPoints >= neededMinimumForKvisko)
                (Owner as InitialForm).Kvisko = true;
            if ((Owner as InitialForm).Player1.ScoredPoints >= neededMinimumForKvisko)
                (Owner as InitialForm).Player1.Kvisko = true;
            if ((Owner as InitialForm).Player2.ScoredPoints >= neededMinimumForKvisko)
                (Owner as InitialForm).Player2.Kvisko = true;
        }

        private void resetForm() {
            //foreach (Control answer in answersGroupBox.Controls) {
            for (int column = 0; column < tableLayoutPanel.ColumnCount; ++column) {
                Control answer = tableLayoutPanel.GetControlFromPosition(column, 1);
                if (answer is RadioButton) {
                    answer.BackColor = SystemColors.Control;
                    answer.Enabled = true;
                }
            }
            answerAradioButton.Checked = true;
            foreach (Control control in tableLayoutPanel.Controls)
                if (control is TextBox)
                    (control as TextBox).BackColor = SystemColors.Control;

            newQuestionCountDownLabel.Text = "";
        }

        public Label Player1NameLabel {
            get { return player1NameLabel; }
        }

        public Label Player2NameLabel {
            get { return player2NameLabel; }
        }

        public Label UsernameLabel {
            get { return usernameLabel; }
        }

        public Label QuestionLabel {
            get { return questionLabel; }
        }

        public RadioButton AnswerARadioButton {
            get { return answerAradioButton; }
        }

        public RadioButton AnswerBRadioButton {
            get { return answerAradioButton; }
        }

        public RadioButton AnswerCRadioButton {
            get { return answerAradioButton; }
        }
    }
}
