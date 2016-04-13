namespace Kviskoteka {
    partial class InitialForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.initialMessageLabel = new System.Windows.Forms.Label();
            this.rulesButton = new System.Windows.Forms.Button();
            this.startTheGameButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAdmins = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(549, 56);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(329, 69);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Kviskoteka";
            // 
            // initialMessageLabel
            // 
            this.initialMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.initialMessageLabel.AutoSize = true;
            this.initialMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialMessageLabel.Location = new System.Drawing.Point(378, 184);
            this.initialMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.initialMessageLabel.Name = "initialMessageLabel";
            this.initialMessageLabel.Size = new System.Drawing.Size(671, 168);
            this.initialMessageLabel.TabIndex = 1;
            this.initialMessageLabel.Text = resources.GetString("initialMessageLabel.Text");
            this.initialMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rulesButton
            // 
            this.rulesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rulesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rulesButton.Location = new System.Drawing.Point(639, 416);
            this.rulesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rulesButton.Name = "rulesButton";
            this.rulesButton.Size = new System.Drawing.Size(149, 33);
            this.rulesButton.TabIndex = 3;
            this.rulesButton.Text = "Pravila";
            this.rulesButton.UseVisualStyleBackColor = true;
            this.rulesButton.Click += new System.EventHandler(this.rulesButton_Click);
            // 
            // startTheGameButton
            // 
            this.startTheGameButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startTheGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startTheGameButton.Location = new System.Drawing.Point(643, 376);
            this.startTheGameButton.Margin = new System.Windows.Forms.Padding(4, 20, 4, 4);
            this.startTheGameButton.Name = "startTheGameButton";
            this.startTheGameButton.Size = new System.Drawing.Size(141, 30);
            this.startTheGameButton.TabIndex = 2;
            this.startTheGameButton.Text = "Započni igru!";
            this.startTheGameButton.UseVisualStyleBackColor = true;
            this.startTheGameButton.Click += new System.EventHandler(this.startTheGameButton_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.buttonClose, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.titleLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.initialMessageLabel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonAdmins, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.rulesButton, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.startTheGameButton, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.50073F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.62226F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.927928F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.846847F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.126126F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.79356F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1427, 683);
            this.tableLayoutPanel.TabIndex = 5;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.Location = new System.Drawing.Point(637, 536);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 39, 4, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(152, 33);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Izađi";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAdmins
            // 
            this.buttonAdmins.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdmins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdmins.Location = new System.Drawing.Point(608, 460);
            this.buttonAdmins.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdmins.Name = "buttonAdmins";
            this.buttonAdmins.Size = new System.Drawing.Size(211, 33);
            this.buttonAdmins.TabIndex = 4;
            this.buttonAdmins.Text = "Za administratore";
            this.buttonAdmins.UseVisualStyleBackColor = true;
            this.buttonAdmins.Click += new System.EventHandler(this.button1_Click);
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 683);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InitialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kviskoteka";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label initialMessageLabel;
        private System.Windows.Forms.Button rulesButton;
        private System.Windows.Forms.Button startTheGameButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button buttonAdmins;
        private System.Windows.Forms.Button buttonClose;
    }
}

