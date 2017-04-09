using System;
using Mediateka.Interfaces;

namespace Mediateka.Classes
{
    public class AudioItem : IMediaItem,IReproduceble
    {
        

        public AudioItem(string name, string url) 
        {
        }

      public string Play
        {
           get
          {
                return string.Format("Now play track: {0}, URL: {1}", Name, Url);
           }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Url
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
