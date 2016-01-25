using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPlayers;

            NumberOfPlayers numberofplayers = new NumberOfPlayers();
            Player1 player1 = new Player1();
            Player2 player2 = new Player2();
            PlayerChooseShape shapechoice = new PlayerChooseShape();
            CheckWinner checkwinner = new CheckWinner();
            UserChooseGameMode userchoosegamemode = new UserChooseGameMode();
            UserPickHandSign userpickhandsign = new UserPickHandSign();
            DisplayScore displayscore = new DisplayScore();
            WriteToDocument writetodocument = new WriteToDocument();
            ReadFromDocument readfromdocument = new ReadFromDocument();


            readfromdocument.WriteDocumentData();

            numberOfPlayers = userchoosegamemode.pickNumberOfPlayers(player1, player2, numberofplayers);

            userpickhandsign.pickHandSign(numberOfPlayers, checkwinner, shapechoice, player1, player2);

            checkwinner.getScore();

            displayscore.DisplayWinner(player1, player2, checkwinner);

            checkwinner.SignClassOutput();

            writetodocument.writeTextToDocument(player1, player2);

            Console.ReadLine();
        }
    }
}
