using Mediateka.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Classes
{
    public class Track: IReproduceble
    {


        public string Url { get; private set; }
        public new string Name { get; protected set; }
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
