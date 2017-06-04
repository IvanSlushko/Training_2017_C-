using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CSVManager : IDisposable
    {
        private string source;

        public CSVManager(string source)
        {
            this.source = source;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            Console.WriteLine("The catalog check is stopped.");
        }

        public void Run()
        {
            Console.WriteLine("The catalog check is started (c:/CSV)");
        }
    }
}
