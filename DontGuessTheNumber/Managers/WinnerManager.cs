using DontGuessTheNumber.Interfaces;
using DontGuessTheNumber.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontGuessTheNumber.Managers
{
    internal class WinnerManager : IWinner
    {
        public bool CheckForWinner(int gameRound, int playerNumber, int computerNumber, decimal winnings, bool gamestatus)
        {
            // check if player has won the game
            if (gameRound > 5 && playerNumber != computerNumber)
            {
                Console.WriteLine($"\nCongratulations! You beat the game. You won ${winnings} dollars.");
                gamestatus = true;
            }
            return gamestatus;
        }
    }
}
