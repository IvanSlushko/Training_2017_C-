using Mediateka.Interfaces;

namespace Mediateka.Classes
{
    public class Track: IReproduceble, IDisk
    {


        public string Url { get; private set; }
        public new string Name { get; protected set; }
        public string Pictures { get; protected set; }
        public Track(string name, string url) 
        {
            this.Name = name;
            Url = url;
        }

        public string Play
        {
            get
            {
                return string.Format("Now play track: {0}, url: {1}", Name, Url);
            }
        }
    }
}
