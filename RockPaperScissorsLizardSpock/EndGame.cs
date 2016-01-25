using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class EndGame : UserInput
    {
        public string EndGameAnswer;

        public void getEndGameAnswer()
        {
            this.EndGameAnswer = getUserInput("Would you like to continue game?  Enter Y or N");
        }
    }
}
