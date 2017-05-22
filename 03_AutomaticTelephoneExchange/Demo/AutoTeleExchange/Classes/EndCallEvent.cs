using AutoTeleExchange.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTeleExchange.Classes
{
     public class EndCallEvent : ICallEvent
    {
        public Guid Id { get; private set; }
        public int TelephoneNumber { get; private set; }
        public int TargetTelephoneNumber { get; private set; }

        public EndCallEvent(Guid id, int number)
        {
            Id = id;
            TelephoneNumber = number;
        }
    }
}
