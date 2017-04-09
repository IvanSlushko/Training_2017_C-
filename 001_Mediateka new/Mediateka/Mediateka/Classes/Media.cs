using Mediateka.Interfaces;
using System.Collections.Generic;

namespace Mediateka.Classes
{
    public class Media: IMedia
    {

        public string Name { get; protected set; }
       // public string Url { get; protected set; }

        public ICollection<IMediaItem> Items
        {
            get;
            private set;
        }

        public Media(string name, ICollection<IMediaItem> items)
        {
            Name = name;
            Items = items;
            //Url = Url;
        }
    }
}
