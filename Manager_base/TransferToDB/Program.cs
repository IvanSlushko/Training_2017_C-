using BL;
using CommaSeparatedValuesService;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferToDB
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = ConfigurationManager.AppSettings["CSVSourceFolder"];
            CSVManager manager = new CSVManager(source);
            manager.Run();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();


            manager.Stop();
        }
    }
}
