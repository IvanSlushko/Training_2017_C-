using BL;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

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
            string source = System.Configuration.ConfigurationManager.AppSettings["CSVSourceFolder"];
            manager = new CSVManager(source);
            manager.Run();
            EventLog.WriteEntry("My service started.");
        }

        protected override void OnStop()
        {
            try
            {
                manager.Stop();
                EventLog.WriteEntry("My service stopped.");
            }
            finally
            {
                manager.Dispose();
            }
        }
    }
}
