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

namespace CSVSer
{
    public partial class Service1 : ServiceBase
    {
        private CSVManager manager;
        public Service1()
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
