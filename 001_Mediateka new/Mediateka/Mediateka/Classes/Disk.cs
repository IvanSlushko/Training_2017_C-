using Mediateka.Interfaces;
using System;
using System.Collections.Generic;

namespace Mediateka.Classes
{
    public class Disk
    {
        public string Name { get; protected set; }
       

        public List<IDisk> Tracks { get; private set; }
        int counter = 12;  //track on disk

        public Disk(string name, List<IDisk> tracks)
        {
            Name = name;
            Tracks = tracks;
        }
        public void AddTrack(IDisk tracks)
        {
            if (Tracks.Count < counter)
            {
                Tracks.Add(tracks);
                Console.WriteLine("On disk {0} tracks.", Tracks.Count);
            }
            else Console.WriteLine("The disk is full, capacity {0} tracks!", counter);
        }
        public void DelTrack(IDisk tracks)
        {
            Tracks.Remove(tracks);
        }
    }
}
