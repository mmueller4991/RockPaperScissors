using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class UserPickHandSign
    {
        Random rnd = new Random();

        public void pickHandSign(int numberOfPlayers, CheckPlayerWin checkplayerwin,PlayerChooseSign signChoice, Player1 player1, Player2 player2) {
            switch (numberOfPlayers)
            {
                case 1:
                    checkplayerwin.player1sign = signChoice.getPlayerHandsign();
                    checkplayerwin.player2sign = rnd.Next(5);
                    break;
                case 2:
                    Console.WriteLine(player1.Player1Name + " it's your turn!");
                    checkplayerwin.player1sign = signChoice.getPlayerHandsign();
                    Console.Clear();
                    Console.WriteLine(player2.Player2Name + " it's your turn!");
                    checkplayerwin.player2sign = signChoice.getPlayerHandsign();
                    Console.Clear();
                    break;
            }
        }
}
}
