using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Interfaces;

namespace Mediateka.Builders.Classes
{
    abstract class MediaItem: IMediaItem
    {
        public MediaItem (string name, string url)
        {
            Name = name;
            Url = url;
        }

        public string Name { get; }
        public string Url { get; }
    }
}
