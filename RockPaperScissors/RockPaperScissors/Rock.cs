using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Rock : IWinLose
    {
        public bool displayLoss()
        {
            Console.WriteLine("Rock loses to paper.");
            return false;
        }

        public bool displayWin()
        {
            Console.WriteLine("Rock wins against scissors.");
            return true;
        }
    }
}
