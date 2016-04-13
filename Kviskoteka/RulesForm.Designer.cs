namespace Kviskoteka {
    partial class RulesForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulesForm));
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Prva igra");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Završna igra");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Igre", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Postavke");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Igrači", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Kvisko");
            this.rulesLabel = new System.Windows.Forms.Label();
            this.rulesDetailsTreeView = new System.Windows.Forms.TreeView();
            this.rulesDetailsLabel = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.player2GroupBox = new System.Windows.Forms.GroupBox();
            this.player2Game1DifficultyDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.player2FinalGameDifficultyDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.player2NameTextBox = new System.Windows.Forms.TextBox();
            this.player2NameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.player1GroupBox = new System.Windows.Forms.GroupBox();
            this.player1NameTextBox = new System.Windows.Forms.TextBox();
            this.player1NameLabel = new System.Windows.Forms.Label();
            this.player1FinalGameDifficultyDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.player1Game1DifficultyDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.player2GroupBox.SuspendLayout();
            this.player1GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // rulesLabel
            // 
            this.rulesLabel.AutoSize = true;
            this.rulesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesLabel.Location = new System.Drawing.Point(22, 28);
            this.rulesLabel.Name = "rulesLabel";
            this.rulesLabel.Size = new System.Drawing.Size(542, 102);
            this.rulesLabel.TabIndex = 0;
            this.rulesLabel.Text = resources.GetString("rulesLabel.Text");
            // 
            // rulesDetailsTreeView
            // 
            this.rulesDetailsTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesDetailsTreeView.Location = new System.Drawing.Point(25, 157);
            this.rulesDetailsTreeView.Name = "rulesDetailsTreeView";
            treeNode7.Name = "game1Node";
            treeNode7.Text = "Prva igra";
            treeNode8.Name = "game3Node";
            treeNode8.Text = "Završna igra";
            treeNode9.Name = "gamesNode";
            treeNode9.Text = "Igre";
            treeNode10.Name = "playersSettingsNode";
            treeNode10.Text = "Postavke";
            treeNode11.Name = "playersNode";
            treeNode11.Text = "Igrači";
            treeNode12.Name = "kviskoNode";
            treeNode12.Text = "Kvisko";
            this.rulesDetailsTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode11,
            treeNode12});
            this.rulesDetailsTreeView.Size = new System.Drawing.Size(182, 312);
            this.rulesDetailsTreeView.TabIndex = 1;
            this.rulesDetailsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.rulesDetailsTreeView_AfterSelect);
            // 
            // rulesDetailsLabel
            // 
            this.rulesDetailsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rulesDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesDetailsLabel.Location = new System.Drawing.Point(0, 0);
            this.rulesDetailsLabel.Name = "rulesDetailsLabel";
            this.rulesDetailsLabel.Size = new System.Drawing.Size(562, 340);
            this.rulesDetailsLabel.TabIndex = 2;
            this.rulesDetailsLabel.Text = "tu ide ipis";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.saveChangesButton);
            this.panel.Controls.Add(this.player2GroupBox);
            this.panel.Controls.Add(this.player1GroupBox);
            this.panel.Controls.Add(this.rulesDetailsLabel);
            this.panel.Location = new System.Drawing.Point(225, 157);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(562, 340);
            this.panel.TabIndex = 4;
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.saveChangesButton.Location = new System.Drawing.Point(246, 318);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(75, 23);
            this.saveChangesButton.TabIndex = 19;
            this.saveChangesButton.Text = "Spremi";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // player2GroupBox
            // 
            this.player2GroupBox.Controls.Add(this.player2Game1DifficultyDomainUpDown);
            this.player2GroupBox.Controls.Add(this.player2FinalGameDifficultyDomainUpDown);
            this.player2GroupBox.Controls.Add(this.player2NameTextBox);
            this.player2GroupBox.Controls.Add(this.player2NameLabel);
            this.player2GroupBox.Controls.Add(this.label4);
            this.player2GroupBox.Controls.Add(this.label6);
            this.player2GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2GroupBox.Location = new System.Drawing.Point(297, 3);
            this.player2GroupBox.Name = "player2GroupBox";
            this.player2GroupBox.Size = new System.Drawing.Size(265, 308);
            this.player2GroupBox.TabIndex = 11;
            this.player2GroupBox.TabStop = false;
            this.player2GroupBox.Text = "Drugi igrač";
            // 
            // player2Game1DifficultyDomainUpDown
            // 
            this.player2Game1DifficultyDomainUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.player2Game1DifficultyDomainUpDown.Items.Add("Lako");
            this.player2Game1DifficultyDomainUpDown.Items.Add("Srednje");
            this.player2Game1DifficultyDomainUpDown.Items.Add("Teško");
            this.player2Game1DifficultyDomainUpDown.Location = new System.Drawing.Point(47, 67);
            this.player2Game1DifficultyDomainUpDown.Name = "player2Game1DifficultyDomainUpDown";
            this.player2Game1DifficultyDomainUpDown.ReadOnly = true;
            this.player2Game1DifficultyDomainUpDown.Size = new System.Drawing.Size(120, 23);
            this.player2Game1DifficultyDomainUpDown.TabIndex = 17;
            this.player2Game1DifficultyDomainUpDown.Text = "....";
            // 
            // player2FinalGameDifficultyDomainUpDown
            // 
            this.player2FinalGameDifficultyDomainUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.player2FinalGameDifficultyDomainUpDown.Items.Add("Lako");
            this.player2FinalGameDifficultyDomainUpDown.Items.Add("Srednje");
            this.player2FinalGameDifficultyDomainUpDown.Items.Add("Teško");
            this.player2FinalGameDifficultyDomainUpDown.Location = new System.Drawing.Point(47, 181);
            this.player2FinalGameDifficultyDomainUpDown.Name = "player2FinalGameDifficultyDomainUpDown";
            this.player2FinalGameDifficultyDomainUpDown.ReadOnly = true;
            this.player2FinalGameDifficultyDomainUpDown.Size = new System.Drawing.Size(120, 23);
            this.player2FinalGameDifficultyDomainUpDown.TabIndex = 15;
            this.player2FinalGameDifficultyDomainUpDown.Text = "....";
            // 
            // player2NameTextBox
            // 
            this.player2NameTextBox.Location = new System.Drawing.Point(47, 269);
            this.player2NameTextBox.Name = "player2NameTextBox";
            this.player2NameTextBox.Size = new System.Drawing.Size(120, 23);
            this.player2NameTextBox.TabIndex = 14;
            // 
            // player2NameLabel
            // 
            this.player2NameLabel.AutoSize = true;
            this.player2NameLabel.Location = new System.Drawing.Point(26, 233);
            this.player2NameLabel.Name = "player2NameLabel";
            this.player2NameLabel.Size = new System.Drawing.Size(30, 17);
            this.player2NameLabel.TabIndex = 13;
            this.player2NameLabel.Text = "Ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Težina završne igre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Težina prve igre";
            // 
            // player1GroupBox
            // 
            this.player1GroupBox.Controls.Add(this.player1NameTextBox);
            this.player1GroupBox.Controls.Add(this.player1NameLabel);
            this.player1GroupBox.Controls.Add(this.player1FinalGameDifficultyDomainUpDown);
            this.player1GroupBox.Controls.Add(this.player1Game1DifficultyDomainUpDown);
            this.player1GroupBox.Controls.Add(this.label1);
            this.player1GroupBox.Controls.Add(this.label3);
            this.player1GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1GroupBox.Location = new System.Drawing.Point(6, 3);
            this.player1GroupBox.Name = "player1GroupBox";
            this.player1GroupBox.Size = new System.Drawing.Size(270, 308);
            this.player1GroupBox.TabIndex = 6;
            this.player1GroupBox.TabStop = false;
            this.player1GroupBox.Text = "Prvi igrač";
            // 
            // player1NameTextBox
            // 
            this.player1NameTextBox.Location = new System.Drawing.Point(51, 269);
            this.player1NameTextBox.Name = "player1NameTextBox";
            this.player1NameTextBox.Size = new System.Drawing.Size(120, 23);
            this.player1NameTextBox.TabIndex = 9;
            // 
            // player1NameLabel
            // 
            this.player1NameLabel.AutoSize = true;
            this.player1NameLabel.Location = new System.Drawing.Point(27, 232);
            this.player1NameLabel.Name = "player1NameLabel";
            this.player1NameLabel.Size = new System.Drawing.Size(34, 17);
            this.player1NameLabel.TabIndex = 8;
            this.player1NameLabel.Text = "Ime:";
            // 
            // player1FinalGameDifficultyDomainUpDown
            // 
            this.player1FinalGameDifficultyDomainUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.player1FinalGameDifficultyDomainUpDown.Items.Add("Lagano");
            this.player1FinalGameDifficultyDomainUpDown.Items.Add("Srednje");
            this.player1FinalGameDifficultyDomainUpDown.Items.Add("Teško");
            this.player1FinalGameDifficultyDomainUpDown.Location = new System.Drawing.Point(51, 180);
            this.player1FinalGameDifficultyDomainUpDown.Name = "player1FinalGameDifficultyDomainUpDown";
            this.player1FinalGameDifficultyDomainUpDown.ReadOnly = true;
            this.player1FinalGameDifficultyDomainUpDown.Size = new System.Drawing.Size(120, 23);
            this.player1FinalGameDifficultyDomainUpDown.TabIndex = 6;
            this.player1FinalGameDifficultyDomainUpDown.Text = "....";
            // 
            // player1Game1DifficultyDomainUpDown
            // 
            this.player1Game1DifficultyDomainUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.player1Game1DifficultyDomainUpDown.Items.Add("Lagano");
            this.player1Game1DifficultyDomainUpDown.Items.Add("Srednje");
            this.player1Game1DifficultyDomainUpDown.Items.Add("Teško");
            this.player1Game1DifficultyDomainUpDown.Location = new System.Drawing.Point(51, 67);
            this.player1Game1DifficultyDomainUpDown.Name = "player1Game1DifficultyDomainUpDown";
            this.player1Game1DifficultyDomainUpDown.ReadOnly = true;
            this.player1Game1DifficultyDomainUpDown.Size = new System.Drawing.Size(120, 23);
            this.player1Game1DifficultyDomainUpDown.TabIndex = 5;
            this.player1Game1DifficultyDomainUpDown.Text = "....";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Težina prve igre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(27, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Težina završne igre";
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.okButton.Location = new System.Drawing.Point(78, 474);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 20;
            this.okButton.Text = "U redu";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // RulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 532);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.rulesDetailsTreeView);
            this.Controls.Add(this.rulesLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RulesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RulesForm";
            this.panel.ResumeLayout(false);
            this.player2GroupBox.ResumeLayout(false);
            this.player2GroupBox.PerformLayout();
            this.player1GroupBox.ResumeLayout(false);
            this.player1GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rulesLabel;
        private System.Windows.Forms.TreeView rulesDetailsTreeView;
        private System.Windows.Forms.Label rulesDetailsLabel;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox player1GroupBox;
        private System.Windows.Forms.TextBox player1NameTextBox;
        private System.Windows.Forms.Label player1NameLabel;
        private System.Windows.Forms.DomainUpDown player1FinalGameDifficultyDomainUpDown;
        private System.Windows.Forms.DomainUpDown player1Game1DifficultyDomainUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox player2GroupBox;
        private System.Windows.Forms.DomainUpDown player2Game1DifficultyDomainUpDown;
        private System.Windows.Forms.DomainUpDown player2FinalGameDifficultyDomainUpDown;
        private System.Windows.Forms.TextBox player2NameTextBox;
        private System.Windows.Forms.Label player2NameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button okButton;
    }
}