using BL.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IRepoTransfer
    {
        void AddSaleInfo(SaleInfo_BL saleInfo_BL);
        IEnumerable<SaleInfo_BL> GetSales();
        IEnumerable<Manager_BL> GetManagers();
        IEnumerable<Client_BL> GetClients();
        IEnumerable<Product_BL> GetProducts();
        void UpdateManager(Manager_BL manager_BL);
        void UpdateSaleInfo(SaleInfo_BL saleInfo_BL);
    }
}
