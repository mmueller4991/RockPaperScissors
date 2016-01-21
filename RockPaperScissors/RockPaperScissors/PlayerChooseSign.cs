using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class PlayerChooseSign:UserInput
    {
 
        public int getPlayerHandsign()
        {
            string chosenSign = null;
            bool isValidHandsign = false;
            int signValue = 0;

            while (isValidHandsign == false)
            {
                chosenSign = getUserInput("Please choose 'rock' 'paper' 'scissors' 'lizard' or 'spock'.");

                switch (chosenSign)
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
                        Console.WriteLine("Unrecognised input.");
                        break; 
                }
                 
            }
            return signValue;
        }  
    }
}
