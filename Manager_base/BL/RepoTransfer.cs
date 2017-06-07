using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.DataTransfer;
using DAL.Repository;

namespace BL
{
    public class RepoTransfer : IRepoTransfer
    {
        private UnitFactory repositories;
        private object locker = new object();

        public RepoTransfer()
        {
            repositories = new UnitFactory();
        }

        public void AddSaleInfo(SaleInfo_BL saleInfo_BL)
        {
            lock (locker)
            {
                var manager = new DAL.Data.Manager_DAL() { SecondName = saleInfo_BL.Manager };
                var client = new DAL.Data.Client_DAL() { FullName = saleInfo_BL.Client };
                var product = new DAL.Data.Product_DAL() { Name = saleInfo_BL.Product };

                var managerId = repositories.Managers.GetId(manager);
                if (managerId == null)
                {
                    repositories.Managers.Add(manager);
                    repositories.Save();
                    managerId = repositories.Managers.GetId(manager);
                }

                var clientId = repositories.Clients.GetId(client);
                if (clientId == null)
                {
                    repositories.Clients.Add(client);
                    repositories.Save();
                    clientId = repositories.Clients.GetId(client);
                }

                var productId = repositories.Products.GetId(product);
                if (productId == null)
                {
                    repositories.Products.Add(product);
                    repositories.Save();
                    productId = repositories.Products.GetId(product);
                }

                var saleInfo = new DAL.Data.SaleInfo_DAL()
                {
                    Date = saleInfo_BL.Date,
                    ManagerId = (int)managerId,
                    ClientId = (int)clientId,
                    ProductId = (int)productId,
                    PriceSum = saleInfo_BL.PriceSum
                };

                repositories.SalesInfo.Add(saleInfo);
                repositories.Save();


                //TODO

                //Console.WriteLine("wait2000");
                //Thread.Sleep(2000);
                //// copy 2 file with delay.
            }

        }

        public IEnumerable<Client_BL> GetClients()
        {
            var client_BL = repositories.Clients.GetAll().Select(c => new Client_BL()
            {
                Id = c.Id,
                FullName = c.FullName
            });
            return client_BL.ToArray();
        }

        public IEnumerable<Manager_BL> GetManagers()
        {
            var manager_BL = repositories.Managers.GetAll().Select(m => new Manager_BL()
            {
                Id = m.Id,
                SecondName = m.SecondName
            });
            return manager_BL.ToArray();
        }

        public IEnumerable<Product_BL> GetProducts()
        {
            var product_BL = repositories.Products.GetAll().Select(p => new Product_BL()
            {
                Id = p.Id,
                Name = p.Name
            });
            return product_BL.ToArray();
        }

        public IEnumerable<SaleInfo_BL> GetSales()
        {
            var saleInfo_BL = repositories.SalesInfo.GetAll().Select(s => new SaleInfo_BL()
            {
                Id = s.Id,
                Date = s.Date,
                Manager = repositories.Managers.GetById(s.ManagerId).SecondName,
                Client = repositories.Clients.GetById(s.ClientId).FullName,
                Product = repositories.Products.GetById(s.ProductId).Name,
                PriceSum = s.PriceSum
            });
            return saleInfo_BL.ToArray();
        }

        public void UpdateManager(Manager_BL manager_BL)
        {
            var manager = repositories.Managers.GetAll().FirstOrDefault(m => (m.Id == manager_BL.Id));
            manager.SecondName = manager_BL.SecondName;
            repositories.Managers.Update(manager);
            repositories.Save();
        }

        public void UpdateSaleInfo(SaleInfo_BL saleInfo_BL)
        {
            var manager = new DAL.Data.Manager_DAL { SecondName = saleInfo_BL.Manager };
            var client = new DAL.Data.Client_DAL() { FullName = saleInfo_BL.Client };
            var product = new DAL.Data.Product_DAL() { Name = saleInfo_BL.Product };

            var managerId = repositories.Managers.GetId(manager);
            if (managerId == null)
            {
                repositories.Managers.Add(manager);
                repositories.Save();
                managerId = repositories.Managers.GetId(manager);
            }

            var clientId = repositories.Clients.GetId(client);
            if (clientId == null)
            {
                repositories.Clients.Add(client);
                repositories.Save();
                clientId = repositories.Clients.GetId(client);
            }

            var productId = repositories.Products.GetId(product);
            if (productId == null)
            {
                repositories.Products.Add(product);
                repositories.Save();
                productId = repositories.Products.GetId(product);
            }

            var saleInfo = new DAL.Data.SaleInfo_DAL()
            {
                Date = saleInfo_BL.Date,
                ManagerId = (int)managerId,
                ClientId = (int)clientId,
                ProductId = (int)productId,
                PriceSum = saleInfo_BL.PriceSum
            };

            var sale = repositories.SalesInfo.GetAll().FirstOrDefault(s => (s.Id == saleInfo_BL.Id));
            sale.Date = saleInfo_BL.Date;
            sale.ManagerId = (int)managerId;
            sale.ClientId = (int)clientId;
            sale.ProductId = (int)productId;
            sale.PriceSum = saleInfo_BL.PriceSum;

            repositories.SalesInfo.Update(sale);
            repositories.Save();
        }
    }
}
