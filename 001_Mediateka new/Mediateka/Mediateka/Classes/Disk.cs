using Mediateka.Classes;
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
        public string Name { get; protected set; }
        private List<ITrack> list;

        public List<IDisk> Tracks { get; private set; }

       
        public Disk(string name, List<IDisk> tracks)
        {
            Name = name;
            Tracks = tracks;
        }
        public string AddTrack(IDisk tracks)
        {
            Tracks.Add(tracks);
            return "Add ";
        }
      
    }
}
