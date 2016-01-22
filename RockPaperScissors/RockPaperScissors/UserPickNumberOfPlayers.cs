using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class UserPickNumberOfPlayers
    {
        


        public int pickNumberOfPlayers (Player1 player1, Player2 player2, NumberOfPlayers numberofplayers)
            {
            int numberOfPlayers;
                bool userHasPickedValidPlayerNumber = false;
                numberOfPlayers = numberofplayers.getNumberOfPlayers();

                while (userHasPickedValidPlayerNumber == false)
                {
                switch (numberOfPlayers)
                {
                    case 2:
                        userHasPickedValidPlayerNumber = true;
                        player1.getPlayer1name();
                        player2.getPlayer2name();
                        break;
                    case 1:
                        userHasPickedValidPlayerNumber = true;
                        player1.getPlayer1name();
                        player2.Player2Name = "AI Andrew";
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
