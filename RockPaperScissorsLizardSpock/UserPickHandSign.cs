using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class UserPickHandSign
    {
        Random rnd = new Random();
        public void pickHandSign(int numberOfPlayers, CheckWinner checkwinner, PlayerChooseShape shapeChoice, Player1 player1, Player2 player2)
        {  switch (numberOfPlayers)
            {
                case 1:
                    checkwinner.player1shape = shapeChoice.getPlayerHandsign();
                    checkwinner.player2shape = rnd.Next(5);
                break;
                case 2:
                    Console.WriteLine(player1.Player1Name + " it is your turn.");
                    checkwinner.player1shape = shapeChoice.getPlayerHandsign();
                    Console.Clear();
                    Console.WriteLine(player2.Player2Name + "it is your turn.");
                    checkwinner.player2shape = shapeChoice.getPlayerHandsign();
                    Console.Clear();
                    break;
        }
        }
    }
}