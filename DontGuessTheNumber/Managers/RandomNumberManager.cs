using DontGuessTheNumber.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontGuessTheNumber.Managers
{
    public class RandomNumberManager
    {      
        private readonly RandomNumber losingNumber = new();
        // use the constructor to generate a random umber at the start

        public int GetLosingNumber()
        {
            Random random = new();
            losingNumber.randomNumber = random.Next(1, 11);
            return losingNumber.randomNumber;
        }
    }
}
