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
    public class ManagerRepository : IDataRepository<DAL.Data.Manager_DAL>
    {
        private DataBaseModelContainer context;

        public ManagerRepository(DataBaseModelContainer context)
        {
            this.context = context;
        }

        public void Add(Manager_DAL item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Manager_DAL> GetAll()
        {
            throw new NotImplementedException();
        }

        public Manager_DAL GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public int? GetId(Manager_DAL item)
        {
            throw new NotImplementedException();
        }

        public void Update(Manager_DAL item)
        {
            throw new NotImplementedException();
        }
    }
}
