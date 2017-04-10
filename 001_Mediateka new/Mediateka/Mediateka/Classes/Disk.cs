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
        private string v;
        private List<IMediaItem> list;

        public List<IDisk> Tracks { get; private set; }

        public Disk()
        {
            Tracks = new List<IDisk>();
        }
        public Disk(List<IDisk> tracks)
        {
           Tracks = tracks;
        }

        public Disk(string v, List<IMediaItem> list)
        {
            this.v = v;
            this.list = list;
        }

        //public void AddTrack(IDisk Tracks)
        //{
        //    Tracks.Add(Tracks);
            
        //}

    }
}
