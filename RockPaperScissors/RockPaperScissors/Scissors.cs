using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Scissors : IWinLose
    {
        public bool displayLoss()
        {
            Console.WriteLine("Scissors loses to rock.");
            return false;
        }

        public bool displayWin()
        {
            Console.WriteLine("Scissors wins against paper.");
            return true;
        }
    }
}
