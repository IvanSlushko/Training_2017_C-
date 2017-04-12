using Mediateka.Interfaces;

namespace Mediateka.Classes
{
    public class Track: IMedia, IReproduceble, IDisk, IEvent
    {


        public string Url { get; private set; }
        public string Name { get; protected set; }
        public string Picture { get; protected set; }
        public Track(string name, string url, string picture) 
        {
            Name = name;
            Url = url;
            Picture = picture;
        }

        public string Play
        {
            get
            {
                return string.Format("Now play track: {0}, url: {1}, pict: {2}", Name, Url, Picture);
            }
        }
    }
}
