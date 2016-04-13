using System;
using System.Windows.Forms;

namespace Kviskoteka {
    public partial class AddQuestionMainForm : Form {
        public AddQuestionMainForm(Form owner)
        {
            this.Owner = owner;
            InitializeComponent();
        }

        private void buttonGame1_Click(object sender, EventArgs e)
        {
            Form form = new AddQuestionSubForm(1, Owner);
            form.ShowDialog();
        }

        private void buttonGame2_Click(object sender, EventArgs e)
        {
            Form form = new AddQuestionSubForm(2, Owner);
            form.ShowDialog();
        }

        private void buttonFinalGame_Click(object sender, EventArgs e)
        {
            Form form = new AddQuestionSubForm(3, Owner);
            form.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
