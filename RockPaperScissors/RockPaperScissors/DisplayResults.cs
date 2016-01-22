using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class DisplayResults
    {

        public void DisplayWinner(Player1 player1, Player2 player2, CheckPlayerWin checkplayerwin)
        {
            switch (checkplayerwin.outcome)
            {
                case 0:
                    Console.WriteLine("You have tied by throwing the same hand sign!");
                    break;
                case 1:
                    Console.WriteLine(player1.Player1Name + " has won!");
                    player1.Winstreak++;
                    player2.Winstreak = 0;
                    break;
                case 2:
                    Console.WriteLine(player2.Player2Name + " has won!");
                    player2.Winstreak++;
                    player1.Winstreak = 0;
                    break;
                case 3:
                    Console.WriteLine(player1.Player1Name + " has won!");
                    player1.Winstreak++;
                    player2.Winstreak = 0;
                    break;
                case 4:
                    Console.WriteLine(player2.Player2Name + " has won!");
                    player2.Winstreak++;
                    player1.Winstreak = 0;
                    break;
            }
        }
}
}
