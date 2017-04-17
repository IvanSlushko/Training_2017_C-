using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearPresent
{
    public abstract class GiftElement
    {
        public string name { get; private set; }
        public int weith { get; private set; }
        public int sugar { get; private set; }
        public int calories { get; private set; }

        public GiftElement(string name, int weith, int sugar, int calories)
        {

        }

    }
}
