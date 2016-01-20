using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player2
    {
        string Player2Name;

        public void getPlayer1name()
        {
            this.Player2Name = getUserInput("Please enter the name for Player 1");
        }
    }
}
