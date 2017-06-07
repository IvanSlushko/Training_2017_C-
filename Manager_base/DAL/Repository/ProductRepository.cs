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
    public class ProductRepository : IDataRepository<DAL.Data.Product_DAL>
    {
        private DataBaseModelContainer context;

        public DataBaseModel.Product ToEntity(DAL.Data.Product_DAL product)
        {
            return new DataBaseModel.Product() { Name = product.Name };
        }

        private DAL.Data.Product_DAL ToObject(DataBaseModel.Product product)
        {
            return new DAL.Data.Product_DAL() { Name = product.Name };
        }

        public ProductRepository(DataBaseModelContainer context)
        {
            this.context = context;
        }

        public void Add(Product_DAL product)
        {
            context.Products.Add(ToEntity(product));
        }

        public IEnumerable<Product_DAL> GetAll()
        {
            return context.Products.Select(p => new DAL.Data.Product_DAL() { Id = p.Id, Name = p.Name }).ToArray();
        }

        public Product_DAL GetById(int Id)
        {
            return ToObject(context.Products.FirstOrDefault(p => (p.Id == Id)));
        }

        public int? GetId(Product_DAL product)
        {
            var temp = context.Products.FirstOrDefault(p => (p.Name == product.Name));
            if (temp == null)
            {
                return null;
            }
            else
            {
                return temp.Id;
            }
        }

        public void Update(Product_DAL item)
        {
            var product = context.Products.FirstOrDefault(p => (p.Id == item.Id));
            product.Name = item.Name;
        }
    }
}
