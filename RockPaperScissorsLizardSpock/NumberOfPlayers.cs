using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    internal class NumberOfPlayers:UserInput
    {
        public int numberofplayers;

        public int getNumberOfPlayers()
        {
            numberofplayers = Convert.ToInt32(getUserInput("1 or 2 players?"));
            return numberofplayers;
        }
    }
}