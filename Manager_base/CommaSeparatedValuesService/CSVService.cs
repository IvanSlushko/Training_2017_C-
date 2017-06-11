using BL;
using System.Configuration;
using System.Diagnostics;
using System.ServiceProcess;

namespace CommaSeparatedValuesService
{
    public partial class CSVService : ServiceBase
    {
        private CSVManager manager;
        public CSVService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            string source = ConfigurationManager.AppSettings["CSVSourceFolder"];
            manager = new CSVManager(source);
            manager.Run();
        }

        protected override void OnStop()
        {
            try
            {
                manager.Stop();
            }
            finally
            {
                manager.Dispose();
            }
        }
    }
}
