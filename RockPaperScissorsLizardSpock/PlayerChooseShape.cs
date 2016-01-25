using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class PlayerChooseShape : UserInput
    {
        public int getPlayerHandsign()
        {
            string chosenShape = null;
            bool isValidHandsign = false;
            int signValue = 0;

            while (isValidHandsign == false)
            {
                chosenShape = getUserInput("Choose rock, paper, scissors, lizard, or spock.");

                switch (chosenShape)
                {
                    case "rock":
                        isValidHandsign = true;
                        signValue = 0;
                        break;
                    case "paper":
                        isValidHandsign = true;
                        signValue = 1;
                        break;
                    case "scissors":
                        isValidHandsign = true;
                        signValue = 2;
                        break;
                    case "spock":
                        isValidHandsign = true;
                        signValue = 3;
                        break;
                    case "lizard":
                        isValidHandsign = true;
                        signValue = 4;
                        break;
                    default:
                        Console.WriteLine("Unrecognized input.");
                        break;
                }
            }
            return signValue;
        }
    }
}