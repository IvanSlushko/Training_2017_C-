using System;
using Mediateka.Interfaces;

namespace Mediateka.Classes
{
    public class AudioItem : MediaComponents,IReproduceble
    {
        

        public AudioItem(string name, string url) : base(name, url)
        {
        }

        public string Play
        {
            get
            {
                return string.Format("Now play track: {0}, URL: {1}", Name, Url);
            }
        }
    }
}
