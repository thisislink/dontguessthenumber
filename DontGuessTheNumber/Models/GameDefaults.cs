using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontGuessTheNumber.Models
{
    internal class GameDefaults
    {
        private int _gameround = 1;
        private decimal _winnings = 0.00M;
        public bool Gameover { get; set; }
        public int GameRound { get => _gameround; set => _gameround = value; } 
        public decimal Winnings { get => _winnings;  set => _winnings = value; }
        public int PlayerNumber { get; set; }
    }
}
