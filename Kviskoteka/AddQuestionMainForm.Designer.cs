namespace Kviskoteka {
    partial class AddQuestionMainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
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
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFinalGame = new System.Windows.Forms.Button();
            this.buttonGame2 = new System.Windows.Forms.Button();
            this.buttonGame1 = new System.Windows.Forms.Button();
            this.labelHeading = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonClose, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonFinalGame, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonGame2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonGame1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelHeading, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDescription, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.66412F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.03053F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.68702F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.29771F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.60305F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.32825F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1082, 655);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonClose.Location = new System.Drawing.Point(501, 505);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(79, 28);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "izađi";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonFinalGame
            // 
            this.buttonFinalGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFinalGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonFinalGame.Location = new System.Drawing.Point(452, 410);
            this.buttonFinalGame.Name = "buttonFinalGame";
            this.buttonFinalGame.Size = new System.Drawing.Size(178, 55);
            this.buttonFinalGame.TabIndex = 6;
            this.buttonFinalGame.Text = "dodaj pitanje za završnu igru";
            this.buttonFinalGame.UseVisualStyleBackColor = true;
            this.buttonFinalGame.Click += new System.EventHandler(this.buttonFinalGame_Click);
            // 
            // buttonGame2
            // 
            this.buttonGame2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonGame2, 2);
            this.buttonGame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonGame2.Location = new System.Drawing.Point(452, 336);
            this.buttonGame2.Name = "buttonGame2";
            this.buttonGame2.Size = new System.Drawing.Size(178, 55);
            this.buttonGame2.TabIndex = 7;
            this.buttonGame2.Text = "dodaj pitanje za igru 2";
            this.buttonGame2.UseVisualStyleBackColor = true;
            this.buttonGame2.Click += new System.EventHandler(this.buttonGame2_Click);
            // 
            // buttonGame1
            // 
            this.buttonGame1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonGame1, 2);
            this.buttonGame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonGame1.Location = new System.Drawing.Point(452, 265);
            this.buttonGame1.Name = "buttonGame1";
            this.buttonGame1.Size = new System.Drawing.Size(178, 55);
            this.buttonGame1.TabIndex = 6;
            this.buttonGame1.Text = "dodaj pitanje za igru zaokruživanja";
            this.buttonGame1.UseVisualStyleBackColor = true;
            this.buttonGame1.Click += new System.EventHandler(this.buttonGame1_Click);
            // 
            // labelHeading
            // 
            this.labelHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHeading.Location = new System.Drawing.Point(407, 65);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(268, 24);
            this.labelHeading.TabIndex = 0;
            this.labelHeading.Text = "Sustav za dodavanje pitanja";
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDescription.Location = new System.Drawing.Point(235, 176);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(612, 60);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Kao administrator imate mogućnost dodavanja novih pitanja za bilo koju od igara.\r" +
    "\nKlikom na donje gumbe otvara se odgovarajuća forma za unos pitanja i odgovora.\r" +
    "\n\r\n";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddQuestionMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 655);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddQuestionMainForm";
            this.Text = "AddQuestionForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonFinalGame;
        private System.Windows.Forms.Button buttonGame2;
        private System.Windows.Forms.Button buttonGame1;
    }
}