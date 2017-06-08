using BL.DataTransfer;
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
        private IRepoTransfer repoTransfer;
        private FileSystemWatcher fileWatcher;

        public CSVManager(string source)
        {
            sourceDir = source;
            repoTransfer = new RepoTransfer();
            fileWatcher = new FileSystemWatcher(source, "*.csv");
            fileWatcher.Created += OnCreated;
            targetDir = string.Concat(source, @"\Done");
            try
            {
                DirectoryInfo targetDirectory = Directory.CreateDirectory(targetDir);
            }
            catch
            {
                Console.WriteLine("Folder 'Done' don't created. Program terminated!");
                System.Threading.Thread.CurrentThread.Abort();
            }
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("ADDED New file: {0}", e.FullPath);

            var taskFileToDB = new Task(() =>
            {
                var sales = Parse(e.FullPath);
                foreach (SaleInfo_BL sale in sales)
                {
                    repoTransfer.AddSaleInfo(sale);
                }
                return;
            }
                                      );
            taskFileToDB.Start();

            var taskMoveFile = taskFileToDB.ContinueWith((r) =>
            {
                try
                {
                    string targetFile = string.Concat(targetDir, @"\", e.Name);
                    if (File.Exists(targetFile))
                    {
                        File.Delete(targetFile);
                    }
                    File.Move(e.FullPath, targetFile);
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Move file exception: {0}", exception.ToString());
                }
                finally
                {
                    Console.WriteLine("{0} moved.", e.Name);
                }
            }
                                                    );
        }

        private ICollection<SaleInfo_BL> Parse(string fullPath)
        {
            ICollection<SaleInfo_BL> sales = new List<SaleInfo_BL>();
            string fileName = fullPath.Substring((fullPath.LastIndexOf(@"\") + 1));
            string manager = fileName.Substring(0, fileName.LastIndexOf("_"));

            using (TextReader reader = File.OpenText(fullPath))
            {
                while (reader.Peek() > -1)
                {
                    string readedLine = reader.ReadLine();
                    var splitSaleInfo = readedLine.Split(',');
                    try
                    {
                        SaleInfo_BL s = new SaleInfo_BL()
                        {
                            Date = DateTime.Parse(splitSaleInfo[0]),
                            Manager = manager,
                            Client = splitSaleInfo[1],
                            Product = splitSaleInfo[2],
                            PriceSum = double.Parse(splitSaleInfo[3])
                        };
                        sales.Add(s);
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine("Parsing exception: {0}", exception.ToString());
                    }
                }
            }
            return sales;
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

        public void GetAllTables()
        {
            try
            {
                Console.WriteLine("Sales:");
                foreach (var sale in repoTransfer.GetSales())
                {
                    Console.WriteLine("{0}, | {1} | {2} | {3} | {4}", sale.Date, sale.Manager, sale.Client, sale.Product, sale.PriceSum);
                }

                Console.WriteLine("\nManagers:");
                foreach (var manager in repoTransfer.GetManagers())
                {
                    Console.WriteLine(manager.SecondName);
                }

                Console.WriteLine("\nClients:");
                foreach (var client in repoTransfer.GetClients())
                {
                    Console.WriteLine(client.FullName);
                }

                Console.WriteLine("\nProducts:");
                foreach (var product in repoTransfer.GetProducts())
                {
                    Console.WriteLine(product.Name);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("EXCEPTION from CSVmanager >>>:\n {0}", exception);
            }
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
