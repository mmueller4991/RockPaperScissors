using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Spock : IWinLose
    {
        public bool displayLoss()
        {
            Console.WriteLine("Spock loses to paper and lizard.");
            return false;
        }

        public bool displayWin()
        {
            Console.WriteLine("Spock wins against scissors and rock.");
            return true;
        }
    }
}
