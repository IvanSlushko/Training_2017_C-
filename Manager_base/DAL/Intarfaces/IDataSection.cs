using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Intarfaces
{
    public interface IDataSection : IDisposable
    {
        IDataRepository<DAL.Data.Client_DAL> Clients { get; }
        IDataRepository<DAL.Data.Manager_DAL> Managers { get; }
        IDataRepository<DAL.Data.Product_DAL> Products { get; }
        IDataRepository<DAL.Data.SaleInfo_DAL> SalesInfo { get; }
        void Save();
    }
}
