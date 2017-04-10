using Mediateka.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Classes
{
    public class Disk
    {
        public List<IDisk> Tracks { get; private set; }

        public Disk()
        {
            Tracks = new List<IDisk>();
        }
        public Disk(List<IDisk> tracks)
        {
           Tracks = tracks;
        }

        public string AddTrack(IDisk Tracks)
        {
            Tracks.Add(Tracks);
            return "Track added" + Tracks;
        }

    }
}
