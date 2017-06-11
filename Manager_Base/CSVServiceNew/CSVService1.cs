using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace CSVServiceNew
{
    public partial class CSVService1 : ServiceBase
    {
        private CSVManager _manager;
        public CSVService1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            string sourceFolder = ConfigurationManager.AppSettings["CSVSourceFolder"];

            _manager = new CSVManager(sourceFolder);
            _manager.Run();
        }

        protected override void OnStop()
        {
            try
            {
                _manager.Stop();
            }
            finally
            {
                _manager.Dispose();
            }
        }
    }
}
