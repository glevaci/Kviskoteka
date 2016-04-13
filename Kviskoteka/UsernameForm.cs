using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kviskoteka {
    public partial class UsernameForm : Form {
        public UsernameForm() {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e) {
            if (UsernameTextbox.Text.Trim() == "")
                MessageBox.Show("Molimo unesite ime");
            else
                DialogResult = DialogResult.OK;
        }

        public TextBox UsernameTextbox {
            get { return usernameTextBox; }
        }

        private void usernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                okButton.PerformClick();
        }
    }
}