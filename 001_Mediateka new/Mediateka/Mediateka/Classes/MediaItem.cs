using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Interfaces;

namespace Mediateka.Builders.Classes
{
    public  class MediaItem: IMediaItem, IReproduceble
    {

        public string Name { get; protected set; }
        public string Url { get; protected set; }
        public MediaItem(string name, ICollection<IMediaItem> items)
        {
            Name = name;
            Url = Url;
        }
        public string Play
        {
            get
            {
                return string.Format("Now play track: {0}, url: ", Name, Url);
            }
        }       
    }
}
