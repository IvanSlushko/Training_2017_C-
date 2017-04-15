using Mediateka.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Mediateka.Classes
{
    public class Serial 
    {
        public List<ISerial> Serials { get; protected set; }

        public Serial()
        {
            Serials = new List<ISerial>();
        }
        public Serial(List<ISerial> serials)
        {
            Serials = serials;
        }

        public void AddToSerials(ISerial serials)
        {
            Serials.Add(serials);
        }

        public void DelFromSerials(ISerial serials)
        {
            Serials.Remove(serials);
        }

        public string PrintAll()
        {
            return Serials.Aggregate<ISerial, string>(null,
                (current, ev) => current +
                ("Сериал: " + ev.GetType().Name+" " + ev.Name +" --> "+ev.Url+ "\n"));
        }
    }
}
