using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Kviskoteka {
    public partial class FinalGameForm : Form
    {
        private bool pressingEnabled = false;
        private bool buttonPlayerPressed = false;
        private bool buttonOpponent1Pressed = false;
        private bool buttonOpponent2Pressed = false;
        
        private int currentPlayer = -1;
        private int nextPlayer;
        private int lastPlayer;

        private long timestampPlayer;
        private long timestampOpponent1;
        private long timestampOpponent2;

        // ove stvari se događaju dijelom istovremeno
        private Timer timerOpponent1Apply = new Timer();
        private Timer timerOpponent2Apply = new Timer();
        private Timer timerPressedPlayer = new Timer();
        private Timer timerPressedOpponent1 = new Timer();
        private Timer timerPressedOpponent2 = new Timer();

        // timer za sve ostalo što se događa sekvencijalno
        private Timer timer = new Timer();

        private int intervalPressed = 100;
        private int timeLeftToWait;
        private static int timeToWait = 2000;

        private Random rand = new Random();

        private int numberOfQuestions;
        private List<int> usedQuestions = new List<int>();
        private List<int> usedAnswers = new List<int>();
        private List<string> allAnswers = new List<string>();
        private static int MAX_QUESTIONS = 5;

        public Label LabelOpponent1 {
            get {
                return labelOpponent1; 
            }
        }

        public Label LabelOpponent2 {
            get { return labelOpponent2; }
        }

        public Label LabelPlayer {
            get { return labelPlayer; }
        }

        public FinalGameForm(Form owner)
        {
            this.Owner = owner;
            InitializeComponent();
            GetNumberOfQuestions();
            StartGame();
        }

        private void GetQuestionWithAnswers()
        {
            int id = rand.Next(1, numberOfQuestions + 1);
            while (usedQuestions.Contains(id))
                id = rand.Next(1, numberOfQuestions + 1);
            usedQuestions.Add(id);

            using (SqlConnection connection = new SqlConnection((Owner as InitialForm).SqlConnectionString)) {
                connection.Open();
                using (SqlCommand cmd = CreateSqlCommand_GetRandomQuestion(id, connection)) {
                    using (SqlDataReader reader = cmd.ExecuteReader()) {
                        reader.Read();
                        labelQuestion.Text = usedQuestions.Count + ". " + reader.GetString(1);
                        GetAllAnswers(reader);
                    }
                }
            }
        }

        private SqlCommand CreateSqlCommand_GetRandomQuestion(int id, SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM FinalGame WHERE QuestionID = @QuestionID";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@QuestionID", id);
            cmd.Connection = connection;
            return cmd;
        }

        private void GetAllAnswers(SqlDataReader reader)
        {
            allAnswers.AddRange(new string[] { reader.GetString(2),
                                                reader.GetString(3),
                                                reader.GetString(4),
                                                reader.GetString(5),
                                                reader.GetString(6)
                        });
        }

        private void GetNumberOfQuestions()
        {
            using (SqlConnection connection = new SqlConnection((Owner as InitialForm).SqlConnectionString)) {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.CommandText = "SELECT COUNT (*) FROM FinalGame";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    numberOfQuestions = (int) cmd.ExecuteScalar();
                }
            }
        }

        private void FinalGameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && pressingEnabled)
                SimulateTasterPress();
        }

        private void SimulateTasterPress()
        {
            if (currentPlayer == -1 && !timerPressedPlayer.Enabled && !buttonPlayerPressed) {
                pictureBoxPlayer.Image = Properties.Resources.taster_pressed;
                buttonPlayerPressed = true;
                timerPressedPlayer.Interval = intervalPressed;
                timerPressedPlayer.Tick += EnablePressingForPlayer;
                timerPressedPlayer.Enabled = true;
                timestampPlayer = DateTime.Now.Ticks;
            }
        }

        private void EnablePressingForPlayer(object sender, EventArgs e)
        {
            timerPressedPlayer.Enabled = false;
            buttonPlayerPressed = false;
            pictureBoxPlayer.Image = Properties.Resources.taster;
        }

        private void StartGame()
        {
            GetQuestionWithAnswers();
            timeLeftToWait = timeToWait;
            timer.Interval = 1000;
            timer.Tick += WaitUntilQuestionIsRead;
            timer.Start();
        }

        private void WaitUntilQuestionIsRead(object sender, EventArgs e) 
        {
            if (timeLeftToWait >= 0) {
                int labelTime = (timeLeftToWait+1000) / 1000;
                labelTimer.Text = labelTime.ToString();
                timeLeftToWait -= 1000;
            }
            else {
                labelTimer.Text = "Započnite s prijavama!";
                timer.Stop();
                timer.Tick -= WaitUntilQuestionIsRead;
                pressingEnabled = true;
                OpponentsApply();
                PeriodicallyCheckForWinner();
            }
        }

        private void PeriodicallyCheckForWinner() 
        {
            timer.Interval = 1000;
            timer.Tick += CheckForWinner;
            timer.Start();
        }

        private void OpponentsApply() 
        {
            timerOpponent1Apply.Interval = rand.Next(1, 500);
            timerOpponent1Apply.Tick += Opponent1Applies;
            timerOpponent1Apply.Enabled = true;

            timerOpponent2Apply.Interval = rand.Next(50, 500);
            timerOpponent2Apply.Tick += Opponent2Applies;
            timerOpponent2Apply.Enabled = true;
        }

        private void Opponent1Applies(object sender, EventArgs e) 
        {
            if (!buttonOpponent1Pressed) {
                timestampOpponent1 = DateTime.Now.Ticks;
                timerOpponent1Apply.Enabled = false;
                pictureBoxOpponent1.Image = Properties.Resources.taster_pressed;
                buttonOpponent1Pressed = true;
                timerPressedOpponent1.Interval = intervalPressed;
                timerPressedOpponent1.Tick += EnablePressingForOpponent1;
                timerPressedOpponent1.Enabled = true;
            }
        }

        private void EnablePressingForOpponent1(object sender, EventArgs e) 
        {
            timerPressedOpponent1.Enabled = false;
            buttonOpponent1Pressed = false;
            pictureBoxOpponent1.Image = Properties.Resources.taster;
            timerOpponent1Apply.Interval = rand.Next(50, 500);
            timerOpponent1Apply.Enabled = true;
        }

        private void Opponent2Applies(object sender, EventArgs e) {
            if (!buttonOpponent2Pressed) {
                timestampOpponent2 = DateTime.Now.Ticks;
                timerOpponent2Apply.Enabled = false;
                pictureBoxOpponent2.Image = Properties.Resources.taster_pressed;
                buttonOpponent2Pressed = true;
                timerPressedOpponent2.Interval = intervalPressed;
                timerPressedOpponent2.Tick += EnablePressingForOpponent2;
                timerPressedOpponent2.Enabled = true;
            }
        }

        private void EnablePressingForOpponent2(object sender, EventArgs e) 
        {
            timerPressedOpponent2.Enabled = false;
            buttonOpponent2Pressed = false;
            pictureBoxOpponent2.Image = Properties.Resources.taster;
            timerOpponent2Apply.Interval = rand.Next(50, 500);
            timerOpponent2Apply.Enabled = true;
        }

        private void CheckForWinner(object sender, EventArgs e) 
        {
            string currentPlayerName = "";
            if (buttonPlayerPressed && !buttonOpponent1Pressed && buttonOpponent2Pressed) {
                StopTimers();
                SetUserAsCurrentPlayer();
                currentPlayerName = (Owner as InitialForm).Username;
            }

            else if (!buttonPlayerPressed && buttonOpponent1Pressed && !buttonOpponent2Pressed) {
                StopTimers();
                SetOpponent1AsCurrentPlayer();
                currentPlayerName = (Owner as InitialForm).Player1.Name;
            }

            else if (!buttonPlayerPressed && !buttonOpponent1Pressed && buttonOpponent2Pressed) {
                StopTimers();
                SetOpponent2AsCurrentPlayer();
                currentPlayerName = (Owner as InitialForm).Player2.Name;
            }

            if (currentPlayer != -1) {
                timer.Tick -= CheckForWinner;
                labelTimer.Text = "Odgovara igrač " + currentPlayerName + ".";
                Answer();
            }
        }

        private void SetOpponent2AsCurrentPlayer()
        {
            currentPlayer = 2;
            if (timestampPlayer > timestampOpponent1) {
                nextPlayer = 0;
                lastPlayer = 1;
            }
            else {
                nextPlayer = 1;
                lastPlayer = 0;
            }
        }

        private void SetOpponent1AsCurrentPlayer()
        {
            currentPlayer = 1;
            if (timestampPlayer > timestampOpponent2) {
                nextPlayer = 0;
                lastPlayer = 2;
            }
            else {
                nextPlayer = 2;
                lastPlayer = 0;
            }
        }

        private void SetUserAsCurrentPlayer()
        {
            currentPlayer = 0;
            if (timestampOpponent1 > timestampOpponent2) {
                nextPlayer = 1;
                lastPlayer = 2;
            }
            else {
                nextPlayer = 2;
                lastPlayer = 1;
            }
        }

        private void Answer()
        {
            if (currentPlayer == 0)
                PlayerAnswers();
            else
                OpponentAnswers();
        }

        private void PlayerAnswers()
        {
            textBoxAnswer.BackColor = System.Drawing.Color.White;
            textBoxAnswer.Clear();
            textBoxAnswer.Enabled = true;
        }

        private void OpponentAnswers()
        {
            textBoxAnswer.Clear();
            textBoxAnswer.Enabled = false;
            textBoxAnswer.BackColor = System.Drawing.Color.White;
            timer.Interval = 1000;
            timer.Tick += WaitBeforeAnswering;
            timer.Start();
        }

        private void GetRandomAnswer()
        {
            double difficulty;
            if (currentPlayer == 1)
                difficulty = (Owner as InitialForm).Player1.FinalGameDifficulty;
            else
                difficulty = (Owner as InitialForm).Player1.FinalGameDifficulty;
            
            int answer = GetRandomAnswerAccordingToDifficulty(difficulty);
            usedAnswers.Add(answer);
            textBoxAnswer.Text = allAnswers.ElementAt(answer);
        }

        private int GetRandomAnswerAccordingToDifficulty(double difficulty)
        {
            int randomNumber = rand.Next(0, 101);
            if (randomNumber <= difficulty)
                return 0;

            else {
                int answer = rand.Next(1, 5);
                while (usedAnswers.Contains(answer))
                    answer = rand.Next(1, 5);
                return answer;
            }
        }

        private void WaitBeforeCheckingAnswer(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Tick -= WaitBeforeCheckingAnswer;
            CheckIfAnswerIsCorrect();
        }
        
        private void CheckIfAnswerIsCorrect()
        {
            // ako je indeks zadnjeg odgovora jednak 0, onda je to prvi odgovor iz baze i točan je
            if (usedAnswers.Last() == 0) {
                AnswerIsCorrect();
            }
            else {
                AnswerIsIncorrect();
            }
            timer.Interval = 1500;
            timer.Start();
        }

        private void AnswerIsIncorrect()
        {
            textBoxAnswer.BackColor = System.Drawing.Color.PaleVioletRed;
            if (usedAnswers.Count == 3) {
                labelTimer.Text = "Sva tri igrača su odgovorila pogrešno! Točan odgovor je "
                                    + allAnswers.ElementAt(0)
                                    + ". Nastavljamo igru sljedećim pitanjem.";
                timer.Tick += Repeat;
            }
            else {
                NextPlayerAnswers();
            }
        }

        private void AnswerIsCorrect()
        {
            textBoxAnswer.BackColor = System.Drawing.Color.PaleGreen;
            AddPointsToCurrentPlayer();
            labelTimer.Text = "Točan odgovor!";
            timer.Tick += Repeat;
        }

        private void NextPlayerAnswers()
        {
            string nextPlayerName = GetNextPlayerName();
            labelTimer.Text = "Pogrešan odgovor! Odgovara sljedeći igrač, " + nextPlayerName + ".";
            timer.Tick += NextPlayerAnswers;
        }

        private string GetNextPlayerName()
        {
            if (nextPlayer == 0)
                return (Owner as InitialForm).Username;
            else if (nextPlayer == 1)
                return (Owner as InitialForm).Player1.Name;
            else
                return (Owner as InitialForm).Player2.Name;
        }

        private void AddPointsToCurrentPlayer()
        {
            int points = 4 - usedAnswers.Count;

            if (currentPlayer == 0) {
                if ((Owner as InitialForm).WhichGameKvisko == 3)
                    points *= 2;
                (Owner as InitialForm).ScoredPoints += points;
            }
            else if (currentPlayer == 1) {
                if ((Owner as InitialForm).Player1.Kvisko)
                    points *= 2;
                (Owner as InitialForm).Player1.ScoredPoints += points;
            }
            else {
                if ((Owner as InitialForm).Player1.Kvisko)
                    points *= 2;
                (Owner as InitialForm).Player1.ScoredPoints += points;
            }
        }

        private void Repeat(object sender, EventArgs e)
        {
            if (usedQuestions.Count == MAX_QUESTIONS) {
                int count = GetNumberOfPlayersWithLargestScore();
                if (count != 1) {
                    MessageBox.Show("Nemamo jedinstvenog pobjednika! Nastavljamo s igrom.");
                    MAX_QUESTIONS++;
                }
                else 
                    FinishFinalGame();
            }

            else {
                timer.Stop();
                timer.Tick -= Repeat;
                ResetData();
                StartGame();
            }
        }

        private void ResetData()
        {
            currentPlayer = -1;
            pressingEnabled = false;
            usedAnswers.Clear();
            allAnswers.Clear();
            labelTimer.Text = "";
            textBoxAnswer.Clear();
            textBoxAnswer.Enabled = false;
            textBoxAnswer.BackColor = System.Drawing.Color.White;
            buttonOpponent1Pressed = false;
            pictureBoxOpponent1.Image = Properties.Resources.taster;
            buttonOpponent2Pressed = false;
            pictureBoxOpponent2.Image = Properties.Resources.taster;
            buttonPlayerPressed = false;
            pictureBoxPlayer.Image = Properties.Resources.taster;
        }

        private int GetNumberOfPlayersWithLargestScore()
        {
            int[] allPlayersPoints = { (Owner as InitialForm).ScoredPoints,
                                            (Owner as InitialForm).Player1.ScoredPoints,
                                            (Owner as InitialForm).Player2.ScoredPoints
                };

            int max = allPlayersPoints.Max();
            int count = allPlayersPoints.Count(item => item == max);
            return count;
        }

        private void FinishFinalGame()
        {
            StopTimers();
            MessageBox.Show("Gotovo!");
            this.Close();
            ResultsForm finalResults = new ResultsForm(3);
            (Owner as InitialForm).populateFormWithData(finalResults);
            finalResults.ShowDialog(this);
        }

        private void NextPlayerAnswers(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Tick -= NextPlayerAnswers;
            textBoxAnswer.Clear();
            textBoxAnswer.BackColor = System.Drawing.Color.White;
            if (nextPlayer == 0)
                PlayerAnswers();
            else {
                OpponentAnswers();
            }
            currentPlayer = nextPlayer;
            nextPlayer = lastPlayer;
        }

        private void WaitBeforeAnswering(object sender, EventArgs e)
        {
            timer.Tick -= WaitBeforeAnswering;
            timer.Stop();
            GetRandomAnswer();
            timer.Tick += WaitBeforeCheckingAnswer;
            timer.Start();
        }

        private void StopTimers() {
            timerOpponent1Apply.Stop();
            timerOpponent2Apply.Stop();
            timerPressedPlayer.Stop();
            timerPressedOpponent1.Stop();
            timerPressedOpponent2.Stop();
            timer.Stop();
        }

        private void textBoxAnswer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBoxAnswer.Text.Trim().Length != 0)
                SubmitAnswer();
        }

        private void SubmitAnswer()
        {
            string trimmedAnswer = textBoxAnswer.Text.Trim();
            int i = allAnswers.FindIndex(x => x.Equals(trimmedAnswer, StringComparison.OrdinalIgnoreCase));
            if (i == -1)
                usedAnswers.Add(-1);
            else
                usedAnswers.Add(i);
            CheckIfAnswerIsCorrect();
        }
    }
}
