using FactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace OfeningFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region bij UnityContainer           
            //var  container = new UnityContainer();
            //container.RegisterType<IRapportGenerator, ExcelRapportGenerator>("excel");
            //container.RegisterType<IRapportGenerator, PdfRapportGenerator>("pdf");
            //container.RegisterType<IRapportGenerator, WordRapportGenerator>("word");

            //var excel = container.Resolve<IRapportGenerator>("excel");
            //var pdf = container.Resolve<IRapportGenerator>("pdf");
            //var word = container.Resolve<IRapportGenerator>("word");
            //excel.GenereerRapport();
            //pdf.GenereerRapport();
            //word.GenereerRapport();
            #endregion
            #region bij Class
            RapportGeneratorFactory factory = new RapportGeneratorFactory();

            IRapportGenerator pdfGenerator = factory.GetRapportGenerator("PDF");
            pdfGenerator.GenereerRapport();

            IRapportGenerator excelGenerator = factory.GetRapportGenerator("EXCEL");
            excelGenerator.GenereerRapport();

            IRapportGenerator wordGenerator = factory.GetRapportGenerator("WORD");
            wordGenerator.GenereerRapport();
            #endregion
        }
      
    }
}
