using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseModel;
using DAL.Intarfaces;
using DAL.Data;

namespace DAL.Repository
{
    public class SaleInfoRepository : IDataRepository<Data.SaleInfo_DAL>
    {
        private DataBaseModelContainer context;

        private DataBaseModel.SaleInfo ToEntity(DAL.Data.SaleInfo_DAL saleInfo)
        {
            return new DataBaseModel.SaleInfo()
            {
                Date = saleInfo.Date,
                ManagerId = saleInfo.ManagerId,
                ClientId = saleInfo.ClientId,
                ProductId = saleInfo.ProductId,
                PriceSum = saleInfo.PriceSum
            };
        }

        private DAL.Data.SaleInfo_DAL ToObject(DataBaseModel.SaleInfo saleInfo)
        {
            return new DAL.Data.SaleInfo_DAL()
            {
                Date = saleInfo.Date,
                ManagerId = saleInfo.ManagerId,
                ClientId = saleInfo.ClientId,
                ProductId = saleInfo.ProductId,
                PriceSum = saleInfo.PriceSum
            };
        }

        public SaleInfoRepository(DataBaseModelContainer context)
        {
            this.context = context;
        }

        public void Add(DAL.Data.SaleInfo_DAL salesInfo)
        {
            this.context.SalesInfo.Add(ToEntity(salesInfo));
        }

        public IEnumerable<SaleInfo_DAL> GetAll()
        {
            throw new NotImplementedException();
        }

        public SaleInfo_DAL GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public int? GetId(SaleInfo_DAL item)
        {
            throw new NotImplementedException();
        }

        public void Update(SaleInfo_DAL item)
        {
            throw new NotImplementedException();
        }
    }
}
