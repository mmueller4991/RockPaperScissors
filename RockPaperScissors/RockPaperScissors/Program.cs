using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfPlayers;
            bool userHasPickedValidPlayerNumber = false;
            string player1sign;
            string player2sign;

            NumberOfPlayers numberofplayers = new NumberOfPlayers();
            Player1 player1 = new Player1();
            Player2 player2 = new Player2();
            PlayerChooseSign signChoice = new PlayerChooseSign();
            Random rnd = new Random();

            numberOfPlayers = numberofplayers.getNumberOfPlayers();

            while(userHasPickedValidPlayerNumber == false)
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
                        break;
                    default:
                        numberOfPlayers = numberofplayers.getNumberOfPlayers();
                        break;
                }
            }
            switch (numberOfPlayers)
            {
                case 1:
                    player1sign = signChoice.getPlayerHandsign();
                    break;
            }
        }
    }
}
