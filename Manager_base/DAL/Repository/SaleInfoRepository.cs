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
    public class SaleInfoRepository : IDataRepository<DAL.Data.SaleInfo_DAL>
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
            context.SalesInfo.Add(ToEntity(salesInfo));
        }

        public IEnumerable<SaleInfo_DAL> GetAll()
        {
            return context.SalesInfo.Select(s => new DAL.Data.SaleInfo_DAL()
            {
                Id = s.Id,
                Date = s.Date,
                ManagerId = s.ManagerId,
                ClientId = s.ClientId,
                ProductId = s.ProductId,
                PriceSum = s.PriceSum
            }
                                            ).ToArray();
        }

        public SaleInfo_DAL GetById(int Id)
        {
            return ToObject(context.SalesInfo.FirstOrDefault(s => (s.Id == Id)));
        }

        public int? GetId(SaleInfo_DAL saleInfo)
        {
            var temp = context.SalesInfo.FirstOrDefault(s => (s.Id == saleInfo.Id));
            if (temp == null)
            {
                return null;
            }
            else
            {
                return temp.Id;
            }
        }

        public void Update(SaleInfo_DAL item)
        {
            var sale = context.SalesInfo.FirstOrDefault(s => (s.Id == item.Id));
            sale.Date = item.Date;
            sale.ManagerId = item.ManagerId;
            sale.ClientId = item.ClientId;
            sale.ProductId = item.ProductId;
            sale.PriceSum = item.PriceSum;
        }
    }
}
