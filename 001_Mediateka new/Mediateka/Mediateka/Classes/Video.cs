
using System;
using Mediateka.Interfaces;

namespace Mediateka.Classes
{
    public class Video: IMedia, IEvent, ISerial, ICompilation
    {

        public string Url { get; private set; }
        public string Name { get; protected set; }
        public Video(string name, string url)
        {
            Name = name;
            Url = url;
        }

        public IMediaStream GetStream()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            throw new NotImplementedException();
        }
    }
}
