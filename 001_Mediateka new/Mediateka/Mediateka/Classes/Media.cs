using Mediateka.Interfaces;
using System.Collections.Generic;
using System;

namespace Mediateka.Classes
{
    public abstract class Media
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public ICollection<IMedia> Items { get; protected set; }

        internal void Play()
        {
            foreach (IMedia item in Items)
            {
                item.Play();
            }
        }

        protected Media(string name, string url)
        {
            Name = name;
            Url = url;
        }
    }
}

