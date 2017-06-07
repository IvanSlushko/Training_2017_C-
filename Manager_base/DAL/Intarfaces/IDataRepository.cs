using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Intarfaces
{
    public interface IDataRepository<T>
    {
        void Add(T item);
        int? GetId(T item);
        IEnumerable<T> GetAll();
        T GetById(int Id);
        void Update(T item);
    }
}
