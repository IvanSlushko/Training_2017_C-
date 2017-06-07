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

        public DataBaseModel.Client ToEntity(DAL.Data.Client_DAL client)
        {
            return new DataBaseModel.Client() { FullName = client.FullName };
        }

        private DAL.Data.Client_DAL ToObject(DataBaseModel.Client client)
        {
            return new DAL.Data.Client_DAL() { FullName = client.FullName };
        }

        public ClientRepository(DataBaseModelContainer context)
        {
            this.context = context;
        }

        public void Add(Client_DAL client)
        {
            context.Clients.Add(ToEntity(client));
        }

        public IEnumerable<Client_DAL> GetAll()
        {
            return context.Clients.Select(c => new DAL.Data.Client_DAL() { Id = c.Id, FullName = c.FullName }).ToArray();
        }

        public Client_DAL GetById(int Id)
        {
            return ToObject(context.Clients.FirstOrDefault(c => (c.Id == Id)));
        }

        public int? GetId(Client_DAL client)
        {
            var temp = context.Clients.FirstOrDefault(c => (c.FullName == client.FullName));
            if (temp == null)
            {
                return null;
            }
            else
            {
                return temp.Id;
            }
        }

        public void Update(Client_DAL item)
        {
            var client = context.Clients.FirstOrDefault(c => (c.Id == item.Id));
            client.FullName = item.FullName;
        }
    }
}
