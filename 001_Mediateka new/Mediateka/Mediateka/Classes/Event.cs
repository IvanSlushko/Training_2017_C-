using Mediateka.Interfaces;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Mediateka.Classes
{
    public class Event  
    {

        public List<IEvent> Events { get; private set; }

        public Event()
        {
            Events = new List<IEvent>();
        }
        public Event(List<IEvent> events)
        {
            Events = events;
        }

        public void AddToEvents(IEvent events)
        {
            Events.Add(events);
        }

        public void DelFromEvents(IEvent events)
        {
            Events.Remove(events);
        }
        //    public static TSource Aggregate<TSource>(
        //   this IEnumerable<TSource> source,
        //   Func<TSource, TSource, TSource> func

        public string PrintAll()
        {
            return Events.Aggregate<IEvent, string>(null, 
                (current, ev) => current +
                ("Событие: " + ev.Name + " " + ev.Url +  "\n"));
        }
      
    }
}
