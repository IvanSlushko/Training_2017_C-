using Mediateka.Interfaces;

namespace Mediateka.Classes
{
    public class Track: IMedia, IReproduceble, IDisk
    {


        public string Url { get; private set; }
        public string Name { get; protected set; }
        public string Picture { get; protected set; }
        public Track(string name, string url, string picture) 
        {
            this.Name = name;
            Url = url;
            Picture = picture;
        }

        public string Play
        {
            get
            {
                return string.Format("Now play track: {0}, url: {1}, pict: ", Name, Url, Picture);
            }
        }
    }
}
