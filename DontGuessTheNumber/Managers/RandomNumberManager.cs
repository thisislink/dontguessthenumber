using DontGuessTheNumber.Interfaces;
using DontGuessTheNumber.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontGuessTheNumber.Managers
{
    internal class RandomNumberManager : IRandomNumber
    {      
        private readonly RandomNumber losingNumber = new();
        // use the constructor to generate a random umber at the start

        public int GetLosingNumber()
        {
            Random random = new();
            losingNumber.GetRandomNumberValue = random.Next(1, 11);
            return losingNumber.GetRandomNumberValue;
        }
    }
}
