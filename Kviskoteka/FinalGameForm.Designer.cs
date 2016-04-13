namespace Kviskoteka {
    partial class FinalGameForm {
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
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelOpponent1 = new System.Windows.Forms.Label();
            this.labelOpponent2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.pictureBoxOpponent2 = new System.Windows.Forms.PictureBox();
            this.labelTimer = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBoxOpponent1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpponent1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPlayer
            // 
            this.labelPlayer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayer.Location = new System.Drawing.Point(561, 625);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.labelPlayer.Size = new System.Drawing.Size(51, 54);
            this.labelPlayer.TabIndex = 0;
            this.labelPlayer.Text = "igrač";
            // 
            // labelOpponent1
            // 
            this.labelOpponent1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelOpponent1.AutoSize = true;
            this.labelOpponent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpponent1.Location = new System.Drawing.Point(148, 625);
            this.labelOpponent1.Name = "labelOpponent1";
            this.labelOpponent1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.labelOpponent1.Size = new System.Drawing.Size(94, 54);
            this.labelOpponent1.TabIndex = 1;
            this.labelOpponent1.Text = "protivnik 1";
            // 
            // labelOpponent2
            // 
            this.labelOpponent2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelOpponent2.AutoSize = true;
            this.labelOpponent2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpponent2.Location = new System.Drawing.Point(931, 625);
            this.labelOpponent2.Name = "labelOpponent2";
            this.labelOpponent2.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.labelOpponent2.Size = new System.Drawing.Size(94, 54);
            this.labelOpponent2.TabIndex = 2;
            this.labelOpponent2.Text = "protivnik 2";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel.Controls.Add(this.labelQuestion, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelOpponent2, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.pictureBoxOpponent2, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.labelTimer, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.pictureBoxPlayer, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.pictureBoxOpponent1, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.labelOpponent1, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.labelPlayer, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.textBoxAnswer, 1, 1);
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.90443F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.435551F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.8637F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.8711F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.92521F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1175, 805);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // labelQuestion
            // 
            this.labelQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelQuestion.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.labelQuestion, 3);
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelQuestion.Location = new System.Drawing.Point(434, 104);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(306, 24);
            this.labelQuestion.TabIndex = 9;
            this.labelQuestion.Text = "Pitanje koje će se izvući iz baze";
            // 
            // pictureBoxOpponent2
            // 
            this.pictureBoxOpponent2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxOpponent2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxOpponent2.Image = global::Kviskoteka.Properties.Resources.taster;
            this.pictureBoxOpponent2.Location = new System.Drawing.Point(903, 477);
            this.pictureBoxOpponent2.MaximumSize = new System.Drawing.Size(150, 150);
            this.pictureBoxOpponent2.Name = "pictureBoxOpponent2";
            this.pictureBoxOpponent2.Size = new System.Drawing.Size(150, 145);
            this.pictureBoxOpponent2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOpponent2.TabIndex = 8;
            this.pictureBoxOpponent2.TabStop = false;
            // 
            // labelTimer
            // 
            this.labelTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTimer.Location = new System.Drawing.Point(586, 378);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(0, 24);
            this.labelTimer.TabIndex = 10;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAnswer.Enabled = false;
            this.textBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAnswer.Location = new System.Drawing.Point(418, 255);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(337, 28);
            this.textBoxAnswer.TabIndex = 11;
            this.textBoxAnswer.Text = "ovdje upišite odgovor";
            this.textBoxAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAnswer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxAnswer_KeyUp);
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxPlayer.Image = global::Kviskoteka.Properties.Resources.taster;
            this.pictureBoxPlayer.Location = new System.Drawing.Point(511, 477);
            this.pictureBoxPlayer.MaximumSize = new System.Drawing.Size(150, 150);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(150, 145);
            this.pictureBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlayer.TabIndex = 3;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // pictureBoxOpponent1
            // 
            this.pictureBoxOpponent1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxOpponent1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxOpponent1.Image = global::Kviskoteka.Properties.Resources.taster;
            this.pictureBoxOpponent1.Location = new System.Drawing.Point(120, 477);
            this.pictureBoxOpponent1.MaximumSize = new System.Drawing.Size(150, 150);
            this.pictureBoxOpponent1.Name = "pictureBoxOpponent1";
            this.pictureBoxOpponent1.Size = new System.Drawing.Size(150, 145);
            this.pictureBoxOpponent1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOpponent1.TabIndex = 7;
            this.pictureBoxOpponent1.TabStop = false;
            // 
            // FinalGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 805);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "FinalGameForm";
            this.Text = "FinalGameForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FinalGameForm_KeyDown);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpponent1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label labelOpponent1;
        private System.Windows.Forms.Label labelOpponent2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.PictureBox pictureBoxOpponent2;
        private System.Windows.Forms.PictureBox pictureBoxOpponent1;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.TextBox textBoxAnswer;
    }
}