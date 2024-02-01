using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary
{
    public class PdfRapportGenerator : IRapportGenerator
    {
        public void GenereerRapport()
        {
            Console.WriteLine("PDF Rapport Generated");
        }
    }
}
