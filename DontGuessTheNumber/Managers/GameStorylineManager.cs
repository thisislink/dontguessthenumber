using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontGuessTheNumber.Managers
{
    internal class GameStorylineManager
    {
        private String? getStoryline;
        public string GetStoryline()
        {
            getStoryline = "\n\nYou can win up to $1500 in fake money. The computer will pick a number between 1 and 10.\nYou will play up to 5 rounds.\nEvery round you will win $100.00 * the round number.\nThe amount you won in the previous round will be added to the amount you win for the current round.\n\nIf you guess the computer's number, you lose. If you make it through all 5 rounds, not guessing the computer's number, you beat the game.\n\nIf you make it to round 3, you are guaranteed to win money. However, if you lose before you get to round 3, you win $0.\n\nGood Luck!";
            return getStoryline;
        }
    }
}
