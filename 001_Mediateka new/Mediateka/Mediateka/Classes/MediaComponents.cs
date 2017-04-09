using Mediateka.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Classes
{
    class MediaComponents:IMediaItem
    {
        public string Name
        {
            get;
            protected set;
        }
        public string Url
        {
            get;
            protected set;
        }
        public MediaComponents(string name, string url)
        {
            Name = name;
            Url = url;
        }
    }
}
