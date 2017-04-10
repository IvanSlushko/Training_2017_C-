
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Classes
{
    public class Video
    {

        public string Url { get; private set; }
        public new string Name { get; protected set; }
        public Video(string name, string url)
        {
            this.Name = name;
            Url = url;
        }
    }
}
