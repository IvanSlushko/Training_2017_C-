
using Mediateka.Interfaces;

namespace Mediateka.Classes
{
    public class Video: IMedia, IEvent
    {

        public string Url { get; private set; }
        public string Name { get; protected set; }
        public Video(string name, string url)
        {
            Name = name;
            Url = url;
        }
    }
}
