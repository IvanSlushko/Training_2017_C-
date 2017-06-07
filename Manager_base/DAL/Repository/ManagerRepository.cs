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

        public DataBaseModel.Manager ToEntity(DAL.Data.Manager_DAL manager)
        {
            return new DataBaseModel.Manager() { SecondName = manager.SecondName };
        }

        private DAL.Data.Manager_DAL ToObject(DataBaseModel.Manager manager)
        {
            return new DAL.Data.Manager_DAL() { SecondName = manager.SecondName };
        }

        public ManagerRepository(DataBaseModelContainer context)
        {
            this.context = context;
        }

        public void Add(Manager_DAL manager)
        {
            context.Managers.Add(ToEntity(manager));
        }

        public IEnumerable<Manager_DAL> GetAll()
        {
            return context.Managers.Select(m => new DAL.Data.Manager_DAL() { Id = m.Id, SecondName = m.SecondName }).ToArray();
        }

        public Manager_DAL GetById(int Id)
        {
            return ToObject(context.Managers.FirstOrDefault(m => (m.Id == Id)));
        }

        public int? GetId(Manager_DAL manager)
        {
            var temp = context.Managers.FirstOrDefault(m => (m.SecondName == manager.SecondName));
            if (temp == null)
            {
                return null;
            }
            else
            {
                return temp.Id;
            }
        }

        public void Update(Manager_DAL item)
        {
            var manager = context.Managers.FirstOrDefault(m => (m.Id == item.Id));
            manager.SecondName = item.SecondName;
        }
    }
}
