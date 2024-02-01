using FactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfeningFactoryPattern
{
    internal class RapportGeneratorFactory
    {
        public IRapportGenerator GetRapportGenerator(string type)
        {
            switch (type.ToUpper())
            {
                case "PDF":
                    return new PdfRapportGenerator();
                case "EXCEL":
                    return new ExcelRapportGenerator();
                case "WORD":
                    return new WordRapportGenerator();
                default:
                    throw new ArgumentException("Ongeldig rapporttype");
            }
        }
    }
}
