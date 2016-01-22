using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player2:UserInput
    {
        public string Player2Name;
        public int Winstreak;

        public void getPlayer2name()
        {
            this.Player2Name = getUserInput("Please enter the name for Player 2");
        }
    }
}
