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
    public class ProductRepository:IDataRepository<DAL.Data.Product_DAL>
    {
        private DataBaseModelContainer context;

        public ProductRepository(DataBaseModelContainer context)
        {
            this.context = context;
        }

        public void Add(Product_DAL item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product_DAL> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product_DAL GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public int? GetId(Product_DAL item)
        {
            throw new NotImplementedException();
        }

        public void Update(Product_DAL item)
        {
            throw new NotImplementedException();
        }
    }
}
