using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Interfaces;

namespace Mediateka.Builders.Classes
{
    abstract class GeneralMediaItem: IMediaItem
    {

        public string Name { get; protected set; }
        //public string Url { get; protected set; }

        public GeneralMediaItem(string name, ICollection<IMediaItem> items)
        {
            Name = name;
         //   Url = Url;
        }
    }
}
