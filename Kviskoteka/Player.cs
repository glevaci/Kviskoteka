using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kviskoteka {

    public class Player {

        private string name;
        //default values for probability of giving correct answer to a certain game
        private double game1Difficulty = 50;
        private double game2Difficulty = 50;
        private double finalGameDifficulty = 50;
        private int scoredPoints;
        private bool kvisko;
        //stake, bet, wage == ulog  (u koju se kvisko igru ulaže: 2 ili 3)
        private int betKviskoInGame;

        public Player (string name) {
            this.name = name;
            this.scoredPoints = 0;
            kvisko = false;
        }

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public double Game1Difficulty {
            get { return game1Difficulty; }
            set { game1Difficulty = value; }
        }

        public double Game2Difficulty {
            get { return game2Difficulty; }
            set { game2Difficulty = value; }
        }

        public double FinalGameDifficulty {
            get { return finalGameDifficulty; }
            set { finalGameDifficulty = value; }
        }

        public int ScoredPoints {
            get { return scoredPoints; }
            set { scoredPoints = value; }
        }

        public bool Kvisko {
            get { return kvisko; }
            set { kvisko = value; }
        }

        public int BetKviskoInGame {
            get { return betKviskoInGame; }
            set { betKviskoInGame = value; }
        }
    }
}
