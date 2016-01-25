using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    internal class UserChooseGameMode
    {
        public int pickNumberOfPlayers (Player1 player1, Player2 player2, NumberOfPlayers numberofplayers)
        {
            int numberOfPlayers;
            bool userPicksValidNumber = false;
            numberOfPlayers = numberofplayers.getNumberOfPlayers();

            while (userPicksValidNumber == false)
            {
                switch (numberOfPlayers)
                {
                    case 2:
                        userPicksValidNumber = true;
                        player1.getPlayer1name();
                        player2.getPlayer2name();
                        break;
                    case 1:
                        userPicksValidNumber = true;
                        player1.getPlayer1name();
                        player2.Player2Name = "HAL 9K";
                        break;
                    default:
                        numberOfPlayers = numberofplayers.getNumberOfPlayers();
                        break;
                }
            }

            return numberOfPlayers;
                    }
            }
}