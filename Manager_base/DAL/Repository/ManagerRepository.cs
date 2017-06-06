using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseModel;

namespace DAL.Repository
{
    public class ManagerRepository
    {
        private DataBaseModelContainer context;

        public ManagerRepository(DataBaseModelContainer context)
        {
            this.context = context;
        }
    }
}
