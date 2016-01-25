using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class DisplayScore
    {
        public void DisplayWinner(Player1 player1, Player2 player2, CheckWinner checkwinner)
        {
            switch (checkwinner.outcome)
            {
                case 0:
                    Console.WriteLine("Players have tied.  Play again.");
                    break;
                case 1:
                    Console.WriteLine(player1.Player1Name + " has won.");
                    player1.Win++;
                    player2.Win = 0;
                    break;
                case 2:
                    Console.WriteLine(player2.Player2Name + " has won.");
                    player2.Win++;
                    player1.Win = 0;
                    break;
                case 3:
                    Console.WriteLine(player1.Player1Name + " has won.");
                    player1.Win++;
                    player2.Win = 0;
                    break;
                case 4:
                    Console.WriteLine(player2.Player2Name + " has won.");
                    player2.Win++;
                    player1.Win = 0;
                    break;
            }
        }
    }
}