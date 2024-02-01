using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary
{
    public class ExcelRapportGenerator : IRapportGenerator
    {
        public void GenereerRapport()
        {
            Console.WriteLine("Excel Rapport Generated");
        }
    }
}
