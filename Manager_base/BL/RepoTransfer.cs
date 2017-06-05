using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.DataTransfer;

namespace BL
{
    public class RepoTransfer : IRepoTransfer
    {
        public RepoTransfer()
        {
           // repositories = new EFUnitOfWork();
        }
        public void AddSaleInfo(SaleInfo_BL saleInfo_BL)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client_BL> GetClients()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Manager_BL> GetManagers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product_BL> GetProducts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SaleInfo_BL> GetSales()
        {
            throw new NotImplementedException();
        }

        public void UpdateManager(Manager_BL manager_BL)
        {
            throw new NotImplementedException();
        }

        public void UpdateSaleInfo(SaleInfo_BL saleInfo_BL)
        {
            throw new NotImplementedException();
        }
    }
}
