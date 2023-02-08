using DontGuessTheNumber.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontGuessTheNumber.Managers
{
    internal class GameTitleManager : IGameTitle
    {
        private string? gameTitle;
        public string GetGameTitle() 
        {
            gameTitle = "Don't Guess the Number";
            return gameTitle;
        }
    }
}
