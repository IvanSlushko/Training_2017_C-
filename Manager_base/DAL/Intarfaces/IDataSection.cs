using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Intarfaces
{
    public interface IDataSection : IDisposable
    {
        IDataRepository<Data.Client_DAL> Clients { get; }
        IDataRepository<Data.Manager_DAL> Managers { get; }
        IDataRepository<Data.Product_DAL> Products { get; }
        IDataRepository<Data.SaleInfo_DAL> SalesInfo { get; }
        void SaveChanges();
    }
}
