using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player1:UserInput
    {
        string Player1Name;

        public void getPlayer1name()
        {
            this.Player1Name = getUserInput("Please enter the name for Player 1");
        }
    }
}
