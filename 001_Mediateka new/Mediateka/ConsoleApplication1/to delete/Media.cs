using Mediateka.Interfaces;
using System.Collections.Generic;

namespace Mediateka.Classes
{
    public class QQQQQMedia : IMedia
    {

        public string Name { get; protected set; }

        public ICollection<ITrack> Items
        {
            get;
            private set;
        }
        public Media(string name, ICollection<ITrack> items)
        {
            Name = name;
            Items = items;
        }
    }
}
