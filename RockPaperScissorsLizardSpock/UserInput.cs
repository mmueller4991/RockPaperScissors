using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class UserInput
    {
        public string getUserInput(string Message)
        {
            Console.WriteLine(Message);
            string userinput = Console.ReadLine();
            return userinput;
        }
    }
}