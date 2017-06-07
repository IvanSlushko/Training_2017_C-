using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Data;
using DAL.Intarfaces;
using DataBaseModel;

namespace DAL.Repository
{
    public class ClientRepository : IDataRepository<DAL.Data.Client_DAL>
    {
        private DataBaseModelContainer context;

        public ClientRepository(DataBaseModelContainer context)
        {
            this.context = context;
        }

        public void Add(Client_DAL item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client_DAL> GetAll()
        {
            throw new NotImplementedException();
        }

        public Client_DAL GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public int? GetId(Client_DAL item)
        {
            throw new NotImplementedException();
        }

        public void Update(Client_DAL item)
        {
            throw new NotImplementedException();
        }
    }
}
