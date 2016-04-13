namespace Kviskoteka {
    partial class FirstGameForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.questionLabel = new System.Windows.Forms.Label();
            this.player1NameLabel = new System.Windows.Forms.Label();
            this.player2NameLabel = new System.Windows.Forms.Label();
            this.answerCRadioButton = new System.Windows.Forms.RadioButton();
            this.answerBRadioButton = new System.Windows.Forms.RadioButton();
            this.answerAradioButton = new System.Windows.Forms.RadioButton();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.player1CorrectAnswerBox = new System.Windows.Forms.TextBox();
            this.userCorrectAnswerBox = new System.Windows.Forms.TextBox();
            this.player2CorrectAnswerBox = new System.Windows.Forms.TextBox();
            this.playersGiveAnswersTimer = new System.Windows.Forms.Timer(this.components);
            this.oneSecondTimer = new System.Windows.Forms.Timer(this.components);
            this.newQuestionCountDownLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionLabel.Location = new System.Drawing.Point(635, 83);
            this.questionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(168, 24);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Ovdje ide pitanje";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1NameLabel
            // 
            this.player1NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.player1NameLabel.AutoSize = true;
            this.player1NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1NameLabel.Location = new System.Drawing.Point(164, 608);
            this.player1NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player1NameLabel.Name = "player1NameLabel";
            this.player1NameLabel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.player1NameLabel.Size = new System.Drawing.Size(150, 44);
            this.player1NameLabel.TabIndex = 1;
            this.player1NameLabel.Text = "Ime prvog igrača";
            this.player1NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2NameLabel
            // 
            this.player2NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.player2NameLabel.AutoSize = true;
            this.player2NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2NameLabel.Location = new System.Drawing.Point(1118, 608);
            this.player2NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player2NameLabel.Name = "player2NameLabel";
            this.player2NameLabel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.player2NameLabel.Size = new System.Drawing.Size(163, 44);
            this.player2NameLabel.TabIndex = 2;
            this.player2NameLabel.Text = "Ime drugog igrača";
            this.player2NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerCRadioButton
            // 
            this.answerCRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answerCRadioButton.AutoSize = true;
            this.answerCRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerCRadioButton.Location = new System.Drawing.Point(1131, 278);
            this.answerCRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.answerCRadioButton.Name = "answerCRadioButton";
            this.answerCRadioButton.Size = new System.Drawing.Size(136, 28);
            this.answerCRadioButton.TabIndex = 2;
            this.answerCRadioButton.TabStop = true;
            this.answerCRadioButton.Text = "radioButton3";
            this.answerCRadioButton.UseVisualStyleBackColor = true;
            this.answerCRadioButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.answerRadioButton_MouseClick);
            // 
            // answerBRadioButton
            // 
            this.answerBRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answerBRadioButton.AutoSize = true;
            this.answerBRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerBRadioButton.Location = new System.Drawing.Point(651, 278);
            this.answerBRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.answerBRadioButton.Name = "answerBRadioButton";
            this.answerBRadioButton.Size = new System.Drawing.Size(136, 28);
            this.answerBRadioButton.TabIndex = 1;
            this.answerBRadioButton.TabStop = true;
            this.answerBRadioButton.Text = "radioButton2";
            this.answerBRadioButton.UseVisualStyleBackColor = true;
            this.answerBRadioButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.answerRadioButton_MouseClick);
            // 
            // answerAradioButton
            // 
            this.answerAradioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answerAradioButton.AutoSize = true;
            this.answerAradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerAradioButton.Location = new System.Drawing.Point(171, 278);
            this.answerAradioButton.Margin = new System.Windows.Forms.Padding(4);
            this.answerAradioButton.Name = "answerAradioButton";
            this.answerAradioButton.Size = new System.Drawing.Size(136, 28);
            this.answerAradioButton.TabIndex = 0;
            this.answerAradioButton.TabStop = true;
            this.answerAradioButton.Text = "radioButton1";
            this.answerAradioButton.UseVisualStyleBackColor = true;
            this.answerAradioButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.answerRadioButton_MouseClick);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameLabel.Location = new System.Drawing.Point(636, 608);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.usernameLabel.Size = new System.Drawing.Size(166, 44);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Ime igrača koji igra";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1CorrectAnswerBox
            // 
            this.player1CorrectAnswerBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.player1CorrectAnswerBox.Enabled = false;
            this.player1CorrectAnswerBox.Location = new System.Drawing.Point(222, 582);
            this.player1CorrectAnswerBox.Margin = new System.Windows.Forms.Padding(4);
            this.player1CorrectAnswerBox.Name = "player1CorrectAnswerBox";
            this.player1CorrectAnswerBox.ReadOnly = true;
            this.player1CorrectAnswerBox.Size = new System.Drawing.Size(35, 22);
            this.player1CorrectAnswerBox.TabIndex = 8;
            // 
            // userCorrectAnswerBox
            // 
            this.userCorrectAnswerBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.userCorrectAnswerBox.Enabled = false;
            this.userCorrectAnswerBox.Location = new System.Drawing.Point(701, 582);
            this.userCorrectAnswerBox.Margin = new System.Windows.Forms.Padding(4);
            this.userCorrectAnswerBox.Name = "userCorrectAnswerBox";
            this.userCorrectAnswerBox.ReadOnly = true;
            this.userCorrectAnswerBox.Size = new System.Drawing.Size(35, 22);
            this.userCorrectAnswerBox.TabIndex = 9;
            // 
            // player2CorrectAnswerBox
            // 
            this.player2CorrectAnswerBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.player2CorrectAnswerBox.Enabled = false;
            this.player2CorrectAnswerBox.Location = new System.Drawing.Point(1182, 582);
            this.player2CorrectAnswerBox.Margin = new System.Windows.Forms.Padding(4);
            this.player2CorrectAnswerBox.Name = "player2CorrectAnswerBox";
            this.player2CorrectAnswerBox.ReadOnly = true;
            this.player2CorrectAnswerBox.Size = new System.Drawing.Size(35, 22);
            this.player2CorrectAnswerBox.TabIndex = 10;
            // 
            // playersGiveAnswersTimer
            // 
            this.playersGiveAnswersTimer.Interval = 2500;
            this.playersGiveAnswersTimer.Tick += new System.EventHandler(this.playersGiveAnswersTimer_Tick);
            // 
            // oneSecondTimer
            // 
            this.oneSecondTimer.Interval = 1000;
            this.oneSecondTimer.Tick += new System.EventHandler(this.oneSecondTimer_Tick);
            // 
            // newQuestionCountDownLabel
            // 
            this.newQuestionCountDownLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newQuestionCountDownLabel.AutoSize = true;
            this.newQuestionCountDownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newQuestionCountDownLabel.Location = new System.Drawing.Point(719, 421);
            this.newQuestionCountDownLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newQuestionCountDownLabel.Name = "newQuestionCountDownLabel";
            this.newQuestionCountDownLabel.Size = new System.Drawing.Size(0, 24);
            this.newQuestionCountDownLabel.TabIndex = 11;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel.Controls.Add(this.player2CorrectAnswerBox, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.usernameLabel, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.player2NameLabel, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.userCorrectAnswerBox, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.player1NameLabel, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.player1CorrectAnswerBox, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.newQuestionCountDownLabel, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.questionLabel, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.answerAradioButton, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.answerBRadioButton, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.answerCRadioButton, 2, 1);
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.51021F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.55102F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.36735F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.36735F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1440, 747);
            this.tableLayoutPanel.TabIndex = 12;
            // 
            // FirstGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 747);
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FirstGameForm";
            this.Text = "FirstGameForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label player1NameLabel;
        private System.Windows.Forms.Label player2NameLabel;
        private System.Windows.Forms.RadioButton answerCRadioButton;
        private System.Windows.Forms.RadioButton answerBRadioButton;
        private System.Windows.Forms.RadioButton answerAradioButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox player1CorrectAnswerBox;
        private System.Windows.Forms.TextBox userCorrectAnswerBox;
        private System.Windows.Forms.TextBox player2CorrectAnswerBox;
        private System.Windows.Forms.Timer playersGiveAnswersTimer;
        private System.Windows.Forms.Timer oneSecondTimer;
        private System.Windows.Forms.Label newQuestionCountDownLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    }
}