using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Lizard : IWinLose
    {
        public bool displayLoss()
        {
            Console.WriteLine("Lizard loses to rock and scissors.");
            return false;
        }

        public bool displayWin()
        {
            Console.WriteLine("Lizard wins against spock and paper.");
            return true;
        }
    }
}
