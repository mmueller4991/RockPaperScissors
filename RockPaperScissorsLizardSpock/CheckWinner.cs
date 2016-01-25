using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class CheckWinner
    {
        public enum handSigns { rock, paper, scissors, spock, lizard };
        Rock rock = new Rock();
        Paper paper = new Paper();
        Scissors scissors = new Scissors();
        Lizard lizard = new Lizard();
        Spock spock = new Spock();

        public int outcome;
        public int player1shape;
        public int player2shape;

        public void getScore()
        {
            outcome = ((5 + player1shape - player2shape) % 5);
        }
        public void SignClassOutput()
        {
            switch (player1shape)
            {
                case 0:
                    if (outcome == 0)
                    {
                        Console.WriteLine("Players have tied.");
                    } else if (outcome == 1 || outcome == 3) {
                        rock.displayWin();
                    }
                    else if (outcome == 2 || outcome == 4)
                    {
                        rock.displayLoss();
                    }
                    break;
                case 1:
                    if (outcome == 0)
                    {
                        Console.WriteLine("You threw the same sign as your opponent and tied.");
                    }
                    else if (outcome == 1 || outcome == 3)
                    {
                        paper.displayWin();
                    }
                    else if (outcome == 2 || outcome == 4)
                    {
                        paper.displayLoss();
                    }
                    break;
                case 2:
                    if (outcome == 0)
                    {
                        Console.WriteLine("You threw the same sign as your opponent and tied.");
                    }
                    else if (outcome == 1 || outcome == 3)
                    {
                        scissors.displayWin();
                    }
                    else if (outcome == 2 || outcome == 4)
                    {
                        scissors.displayLoss();
                    }
                    break;
                case 3:
                    if (outcome == 0)
                    {
                        Console.WriteLine("You threw the same sign as your opponent and tied.");
                    }
                    else if (outcome == 1 || outcome == 3)
                    {
                        spock.displayWin();
                    }
                    else if (outcome == 2 || outcome == 4)
                    {
                        spock.displayLoss();
                    }
                    break;
                case 4:
                    if (outcome == 0)
                    {
                        Console.WriteLine("You threw the same sign as your opponent and tied.");
                    }
                    else if (outcome == 1 || outcome == 3)
                    {
                        lizard.displayWin();
                    }
                    else if (outcome == 2 || outcome == 4)
                    {
                        lizard.displayLoss();
                    }
                    break;
            }
        }
    }
}