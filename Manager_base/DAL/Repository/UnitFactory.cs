using DAL.Intarfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Data;
using DataBaseModel;

namespace DAL.Repository
{
    public class UnitFactory : IDataSection
    {

        private DataBaseModelContainer context;
        private ClientRepository clientRepository;
        private ManagerRepository managerRepository;
        private ProductRepository productRepository;
        private SaleInfoRepository saleInfoRepository;

        public UnitFactory()
        {
            context = new DataBaseModelContainer();
        }

        public IDataRepository<Client_DAL> Clients
        {
            get
            {
                if (clientRepository == null)
                {
                    clientRepository = new ClientRepository(context);
                }
                return clientRepository;
            }
        }

        public IDataRepository<Manager_DAL> Managers
        {
            get
            {
                if (managerRepository == null)
                {
                    managerRepository = new ManagerRepository(context);
                }
                return managerRepository;
            }
        }

        public IDataRepository<Product_DAL> Products
        {
            get
            {
                if (productRepository == null)
                {
                    productRepository = new ProductRepository(context);
                }
                return productRepository;
            }
        }

        public IDataRepository<SaleInfo_DAL> SalesInfo
        {
            get
            {
                if (saleInfoRepository == null)
                {
                    saleInfoRepository = new SaleInfoRepository(context);
                }
                return saleInfoRepository;
            }
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
