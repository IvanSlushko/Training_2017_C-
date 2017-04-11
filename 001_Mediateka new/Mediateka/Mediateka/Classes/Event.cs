﻿using Mediateka.Interfaces;
using System.Collections.Generic;
using System;

namespace Mediateka.Classes
{
    class Event :  IPicture, IVideo 
    {
        public List<IEvent> Events { get; private set; }

        public Event()
        {
            Events = new List<IEvent>();
        }

        public Event(List<IEvent> eventt)
        {
            Events = eventt;
        }

        public void AddToEvent(IEvent eventt)
        {
            Events.Add(eventt);
        }
        public void DelFromEvent(IEvent eventt)
        {
            Events.Remove(eventt);
        }
        public void SortEvent(IEvent eventt)
        {
            Events.Sort();
        }


    }
}
