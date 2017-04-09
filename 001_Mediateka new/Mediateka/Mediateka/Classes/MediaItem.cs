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
 
        public MediaItem(string name, string url)
        {
            this.Name = name;
            Url = url;
        }

        public string Name { get; protected set; }
        public string Url { get; protected set; }

        public string Play
        {
            get
            {
                return string.Format("Now play track: {0}, url: {1}", Name, Url);
            }
        }       
    }
}
