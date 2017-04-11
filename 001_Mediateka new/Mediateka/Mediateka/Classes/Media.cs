using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Classes
{
    public abstract class Media
    {
        public string Name { get; set; }
        public string Url { get; set; }

        protected Media(string name, string url)
        {
            Name = name;
            Url = url;
        }
    }
}
