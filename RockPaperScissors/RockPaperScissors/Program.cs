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

            NumberOfPlayers numberofplayers = new NumberOfPlayers();
            Player1 player1 = new Player1();
            Player2 player2 = new Player2();
            PlayerChooseSign signChoice = new PlayerChooseSign();
            CheckPlayerWin checkplayerwin = new CheckPlayerWin();
            UserPickNumberOfPlayers userpicknumberofplayers = new UserPickNumberOfPlayers();
            UserPickHandSign userpickhandsign = new UserPickHandSign();
            DisplayResults displayresults = new DisplayResults();
            WriteToDocument writetodocument = new WriteToDocument();
            ReadFromDocument readfromdocument = new ReadFromDocument();

            readfromdocument.writeDocumentContent();

            numberOfPlayers = userpicknumberofplayers.pickNumberOfPlayers(player1, player2, numberofplayers);

            userpickhandsign.pickHandSign(numberOfPlayers, checkplayerwin, signChoice, player1, player2);
           
            checkplayerwin.getResult();

            displayresults.DisplayWinner(player1, player2, checkplayerwin);

            checkplayerwin.SignClassOutput();

            writetodocument.writeTextToDocument(player1, player2);
        }
    }
}
