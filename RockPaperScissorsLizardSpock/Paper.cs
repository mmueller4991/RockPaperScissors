using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Paper : IWinLose
    {
        public bool displayLoss()
        {
            Console.WriteLine("Paper loses to scissors and lizard.");
            return false;
        }

        public bool displayWin()
        {
            Console.WriteLine("Paper wins against rock and spock.");
            return true;
        }
    }
}
