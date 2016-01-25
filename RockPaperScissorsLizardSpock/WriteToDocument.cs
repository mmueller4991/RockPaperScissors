using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class WriteToDocument
    {
        public void writeTextToDocument(Player1 player1, Player2 player2)
        {
            string[] playernames = { player1.Player1Name, player2.Player2Name };

            System.IO.File.WriteAllLines(@"C:\Users\Mueller\Documents\Visual Studio 2015\Projects\RockPaperScissorsLizardSpock\Muellerplayers.txt", playernames);
        }
     }
}