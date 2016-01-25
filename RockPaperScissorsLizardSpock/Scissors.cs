using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Scissors : IWinLose
    {
        public bool displayLoss()
        {
            Console.WriteLine("Scissors loses to rock and spock.");
            return false;
        }

        public bool displayWin()
        {
            Console.WriteLine("Scissors wins against paper and lizard.");
            return true;
        }
    }
}
