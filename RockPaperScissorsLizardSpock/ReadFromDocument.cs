using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class ReadFromDocument
    {
        string documentData = System.IO.File.ReadAllText(@"C:\Users\Mueller\Documents\Visual Studio 2015\Projects\RockPaperScissorsLizardSpock\ReadTextFile.txt");

        public void WriteDocumentData()
        {
            Console.WriteLine(documentData);

        }
    }
}