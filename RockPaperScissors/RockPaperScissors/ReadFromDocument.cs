using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class ReadFromDocument
    {
        string documentContent = System.IO.File.ReadAllText(@"C:\Users\Robert\Documents\devcodecamp\RockPaperScissors\ReadTextFile.txt");

        public void writeDocumentContent()
        {
            Console.WriteLine(documentContent);
        }
    }
}
