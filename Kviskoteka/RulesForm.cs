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
    public partial class RulesForm : Form {
        public RulesForm() {
            InitializeComponent();
        }

        private void rulesDetailsTreeView_AfterSelect(object sender, TreeViewEventArgs e) {
            TreeNode selectedNode = e.Node;

            switch (selectedNode.Text) {
                case "Igre":
                    rulesDetailsLabel.Text = "";
                    player1GroupBox.Visible = false;
                    player2GroupBox.Visible = false;
                    saveChangesButton.Visible = false;

                    break;
                case "Prva igra":
                    player1GroupBox.Visible = false;
                    player2GroupBox.Visible = false;
                    saveChangesButton.Visible = false;
                    rulesDetailsLabel.Text = "Prva igra analogon je testu na zaokruživanje.\n\n" +
                                            "Preciznije, na svako pitanje ponuđena su tri odgovora. Igrači odgovaraju na pitanja, " +
                                            "pri čemu točan odgovor nosi dva boda, netočan nula.\n" + 
                                            "Nema vremenskog ograničenja.\n\n" +
                                            "Ako neki od igrača da točan odgovor, kvadratić ispod njegova imena postat će zelen. " +
                                            "U suprotnom će se zacrveniti.\n\n" +
                                            "Igrači koji osvoje barem 75% bodova dobivaju Kviska - za detalje pogledati dolje.";
                    break;
                case "Završna igra":
                    player1GroupBox.Visible = false;
                    player2GroupBox.Visible = false;
                    saveChangesButton.Visible = false;

                    rulesDetailsLabel.Text = "Završna igra sastoji se od pitanja bez ponuđenih odgovora.\n\n" +
                                            "Natjecatelji se za davanje odgovora prijavljuju pritiskom tipke Space. \n\n" +
                                            "U kratkim vremenskim intervalima se provjerava je li pritisnut samo jedan taster. Ukoliko je, " +
                                            "onaj igrač čiji taster je pritisnut ima pravo odgovoriti na pitanje. Ukoliko da točan odgovor, dobiva 3 boda. \n" +
                                            "U protivnom odgovara onaj igrač čiji je trenutak prijave bio najbliži dopuštenom intervalu za prijavu. " + 
                                            "On za točan odgovor može dobiti 2 boda. " +
                                            "Ukoliko i on pogriješi, odgovara zadnji po redu igrač i za svoj odgovor može dobiti 1 bod.\n\n" + 
                                            "Ukoliko svo troje igrača odgovori pogrešno, nitko ne dobiva bodove i prelazi se na sljedeće pitanje.";
                    break;

                case "Igrači":
                    player1GroupBox.Visible = false;
                    player2GroupBox.Visible = false;
                    saveChangesButton.Visible = false;

                    rulesDetailsLabel.Text = "U svakom od igara protivnici su vam računalni igrači koje možete imenovati.\n\n" +
                                            "Svakom igraču možete odrediti težinu za svaku igru od koje se kviz sastoji.\n" +
                                            "Ukoliko to ne učinite, težina će na svakoj biti \"Lako\"" + "\n\n" + 
                                            "Za više kliknite na \"Postavke\".";
                    break;
                case "Postavke":
                    rulesDetailsLabel.Text = "";
                    player1GroupBox.Visible = true;
                    player2GroupBox.Visible = true;
                    saveChangesButton.Visible = true;
                    break;

                case "Kvisko":
                    player1GroupBox.Visible = false;
                    player2GroupBox.Visible = false;
                    saveChangesButton.Visible = false;
                    rulesDetailsLabel.Text = "Igrači koji osvoje barem 75% bodova u prvoj igri dobivaju Kviska.\n\n" +
                                            "Kvisko se može uložiti u neku od sljedećih igara te donosi dvostruki broj bodova na svako pitanje.\n\n" +
                                            "Kviska igrač ne mora uložiti, a njegovo posjedovanje na kraju igre nema efekta.";
                    break;
            }
        }

        private void saveChangesButton_Click(object sender, EventArgs e) {
            Player player1 = (Owner as InitialForm).Player1;
            Player player2 = (Owner as InitialForm).Player2;
            setNameAndDifficultyForAPlayer(1, player1);
            setNameAndDifficultyForAPlayer(2, player2);
            MessageBox.Show("Spremljeno!");
        }

        private void setNameAndDifficultyForAPlayer(int whichPlayer, Player player ) {
            if (whichPlayer == 1) {
                if (player1NameTextBox.Text.Trim() != "" )
                    player.Name = player1NameTextBox.Text;

                if (player1Game1DifficultyDomainUpDown.SelectedIndex != -1)
                    setPlayerDifficultyToAGame(1, player, player1Game1DifficultyDomainUpDown);

                

                if (player1FinalGameDifficultyDomainUpDown.SelectedIndex != -1)
                    setPlayerDifficultyToAGame(3, player, player1FinalGameDifficultyDomainUpDown);

            } else {
                if (player2NameTextBox.Text.Trim() != "")
                    player.Name = player2NameTextBox.Text;

                if (player2Game1DifficultyDomainUpDown.SelectedIndex != -1)
                    setPlayerDifficultyToAGame(1, player, player2Game1DifficultyDomainUpDown);


                if (player2FinalGameDifficultyDomainUpDown.SelectedIndex != -1)
                    setPlayerDifficultyToAGame(3, player, player2FinalGameDifficultyDomainUpDown);
            }
        }

        private void setPlayerDifficultyToAGame(int whichGame, Player player, DomainUpDown domainUpDown) {
            switch (domainUpDown.SelectedItem.ToString()) {
                case "Lako":
                    if (whichGame == 1)
                        player.Game1Difficulty = 50;
                    else if (whichGame == 2)
                        player.Game2Difficulty = 50;
                    else
                        player.FinalGameDifficulty = 50;
                    break;

                case "Srednje":
                    if (whichGame == 1)
                        player.Game1Difficulty = 75;
                    else if (whichGame == 2)
                        player.Game2Difficulty = 75;
                    else
                        player.FinalGameDifficulty = 75;
                    break;

                case "Teško":
                    if (whichGame == 1)
                        player.Game1Difficulty = 90;
                    else if (whichGame == 2)
                        player.Game2Difficulty = 90;
                    else
                        player.FinalGameDifficulty = 90;
                    break;
            }
        }
        
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
