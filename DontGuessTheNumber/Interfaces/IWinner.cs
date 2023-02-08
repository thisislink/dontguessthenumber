using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontGuessTheNumber.Interfaces
{
    internal interface IWinner
    {
        bool CheckForWinner(int gameRound, int playerNumber, int computerNumber, decimal winnings, bool gamestatus);
    }
}
