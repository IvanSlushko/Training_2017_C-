using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CSVManager : IDisposable
    {
        private string sourceDir;
        private string targetDir;

        private FileSystemWatcher fileWatcher;



        public CSVManager(string source)
        {
            sourceDir = source;
            fileWatcher = new FileSystemWatcher(source, "*.csv");
            fileWatcher.Created += OnCreated;
            targetDir = string.Concat(source, @"\Done");
            try
            {
                DirectoryInfo targetDirectory = Directory.CreateDirectory(targetDir);
            }
            catch
            {
                Console.WriteLine("It can not be created 'Done' folder!.\nProgram stop!");
                System.Threading.Thread.CurrentThread.Abort();
            }
        }


        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("ADDED New file: {0}", e.FullPath);


            //TODO
        }


        public void Stop()
        {
            if (fileWatcher != null && fileWatcher.EnableRaisingEvents)
            {
                fileWatcher.EnableRaisingEvents = false;
            }
            Console.WriteLine("The catalog check is stopped.");
        }

        public void Run()
        {
            if (fileWatcher != null && !fileWatcher.EnableRaisingEvents)
            {
                fileWatcher.EnableRaisingEvents = true;
            }
            Console.WriteLine("The catalog {0} check is started.", sourceDir);
        }

        #region IDisposable
        public void Dispose()
        {
            if (fileWatcher != null)
            {
                Stop();
                fileWatcher.Dispose();
                fileWatcher = null;
            }
        }

        ~CSVManager()
        {
            Dispose();
        }
        #endregion 
    }
}
