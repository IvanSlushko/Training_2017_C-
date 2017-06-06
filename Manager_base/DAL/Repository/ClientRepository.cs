using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseModel;

namespace DAL.Repository
{
    public class ClientRepository
    {
        private DataBaseModelContainer context;

        public ClientRepository(DataBaseModelContainer context)
        {
            this.context = context;
        }
    }
}
