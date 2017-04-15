using System;
using Mediateka.Interfaces;

namespace Mediateka.Classes
{
    public class Track : IMedia, IDisk, IEvent, ICompilation, ISerial

    {
        public string Url { get; private set; }
        public string Name { get; protected set; }
        public Track(string name, string url)
        {
            Name = name;
            Url = url;
        }

        public string Play
        {
            get
            {
                return string.Format("Now play track: {0}, url: {1}", Name, Url);
            }
        }

        public IMediaStream GetStream()
        {
            throw new NotImplementedException();
        }

        void IMedia.Play()
        {
            throw new NotImplementedException();
        }
    }
}
