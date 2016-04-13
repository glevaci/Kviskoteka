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
    public partial class PlayersSettingsForm : Form {
        public PlayersSettingsForm() {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        public DomainUpDown Player1Game1DifficultyDomainUpDown {
            get { return player1Game1DifficultyDomainUpDown; }
        }

        public DomainUpDown Player1Game2DifficultyDomainUpDown {
            get { return player1Game2DifficultyDomainUpDown; }
        }

        public DomainUpDown Player1FinalGameDifficultyDomainUpDown {
            get { return player1FinalGameDifficultyDomainUpDown; }
        }

        public TextBox Player1NameTextBox {
            get { return player1NameTextBox; }
        }

        public DomainUpDown Player2Game1DifficultyDomainUpDown {
            get { return player2Game1DifficultyDomainUpDown; }
        }

        public DomainUpDown Player2Game2DifficultyDomainUpDown {
            get { return player2Game2DifficultyDomainUpDown; }
        }

        public DomainUpDown Player2FinalGameDifficultyDomainUpDown {
            get { return player2FinalGameDifficultyDomainUpDown; }
        }

        public TextBox Player2NameTextBox {
            get { return player2NameTextBox; }
        }
    }
}
