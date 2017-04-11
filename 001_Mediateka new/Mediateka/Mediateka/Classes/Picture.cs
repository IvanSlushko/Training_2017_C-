using Mediateka.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Classes
{
    public class Picture: IDisk, IMedia

    {
        public string Url { get; private set; }
        public string Name { get; protected set; }

        public string Pictures
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Picture(string name, string url)
        {
            Name = name;
            Url = url;
        }
    }
}
