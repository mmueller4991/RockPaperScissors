using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Rock : IWinLose
    {
        public bool displayLoss()
        {
            Console.WriteLine("Rock loses to paper and spock.");
            return false;
        }

        public bool displayWin()
        {
            Console.WriteLine("Rock wins against scissors and lizard.");
            return true;
        }
    }
}