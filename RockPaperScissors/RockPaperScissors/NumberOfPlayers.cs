using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class NumberOfPlayers:UserInput
    {
        public int numberOfPlayers;

        public int getNumberOfPlayers()
        {
            numberOfPlayers = Convert.ToInt32(getUserInput("1 or 2 players?"));
            return numberOfPlayers;
        }

    }
}
