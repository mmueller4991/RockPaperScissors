using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class WriteToDocument
    {
        public void writeTextToDocument(Player1 player1, Player2 player2)
        {
            string[] playernames = { player1.Player1Name, player2.Player2Name };

            System.IO.File.WriteAllLines(@"C:\Users\Robert\Documents\devcodecamp\RockPaperScissors\RPSplayers.txt", playernames);
        }
    }
}
