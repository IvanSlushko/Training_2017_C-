using AutoTeleExchange.Enums;
using AutoTeleExchange.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTeleExchange.Classes
{
    public class AnswerEvent : ICallEvent 
    {
        public CallStatus InCall;
        public int TelephoneNumber { get; private set; }
        public int TargetTelephoneNumber { get; private set; }
        public Guid Id { get; private set; }
        public AnswerEvent(int number, int target, CallStatus status)
        {
            TelephoneNumber = number;
            TargetTelephoneNumber = target;
            InCall = status;
        }
        public AnswerEvent(int number, int target, CallStatus status, Guid id)
        {
            TelephoneNumber = number;
            TargetTelephoneNumber = target;
            InCall = status;
            Id = id;
        }
    }
}
