using AutoTeleExchange.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTeleExchange.Classes
{
    public class Port
    {
        public PortStatus Status;
        public bool Flag;

        public event EventHandler<CallEvent> CallEvent;
        public event EventHandler<CallEvent> CallPortEvent;
        public event EventHandler<AnswerEvent> AnswerEvent;
        public event EventHandler<AnswerEvent> AnswerPortEvent;
        public event EventHandler<EndCallEvent> EndCallEvent;

        public Port()
        {
            Status = PortStatus.Disconnect;
        }

        public bool Connect(Terminal terminal)
        {
            if (Status == PortStatus.Disconnect)
            {
                Status = PortStatus.Connect;
                terminal.CallEvent += CallingTo;
                terminal.AnswerEvent += AnswerTo;
                terminal.EndCallEvent += EndCall;
                Flag = true;
            }
            return Flag;
        }
        public bool Disconnect(Terminal terminal)
        {
            if (Status == PortStatus.Connect)
            {
                Status = PortStatus.Disconnect;
                terminal.CallEvent -= CallingTo;
                terminal.AnswerEvent -= AnswerTo;
                terminal.EndCallEvent -= EndCall;
                Flag = false;
            }
            return false;
        }

        protected virtual void IncomingCallEvent(int number, int targetNumber)
        {
            CallPortEvent?.Invoke(this, new CallEvent(number, targetNumber));
        }
        protected virtual void IncomingCallEvent(int number, int targetNumber, Guid id)
        {
            CallPortEvent?.Invoke(this, new CallEvent(number, targetNumber, id));
        }
        protected virtual void AnswerCallEvent(int number, int targetNumber, CallStatus status)
        {
            AnswerPortEvent?.Invoke(this, new AnswerEvent(number, targetNumber, status));
        }
        protected virtual void AnswerCallEvent(int number, int targetNumber, CallStatus status, Guid id)
        {
            AnswerPortEvent?.Invoke(this, new AnswerEvent(number, targetNumber, status, id));
        }
        protected virtual void CallingToEvent(int number, int targetNumber)
        {
            CallEvent?.Invoke(this, new CallEvent(number, targetNumber));
        }
        protected virtual void AnswerToEvent(AnswerEvent eventArgs)
        {
            AnswerEvent?.Invoke(this, new AnswerEvent(
            eventArgs.TelephoneNumber,
            eventArgs.TargetTelephoneNumber,
            eventArgs.InCall,
            eventArgs.Id));
        }
        protected virtual void UpEndCallEvent(Guid id, int number)
        {
            EndCallEvent?.Invoke(this, new EndCallEvent(id, number));
        }

        private void CallingTo(object sender, CallEvent e)
        {
            CallingToEvent(e.TelephoneNumber, e.TargetTelephoneNumber);
        }
        private void AnswerTo(object sender, AnswerEvent e)
        {
            AnswerToEvent(e);
        }
        private void EndCall(object sender, EndCallEvent e)
        {
            UpEndCallEvent(e.Id, e.TelephoneNumber);
        }

        public void IncomingCall(int number, int targetNumber)
        {
            IncomingCallEvent(number, targetNumber);
        }
        public void IncomingCall(int number, int targetNumber, Guid id)
        {
            IncomingCallEvent(number, targetNumber, id);
        }

        public void AnswerCall(int number, int targetNumber, CallStatus status)
        {
            AnswerCallEvent(number, targetNumber, status);
        }
        public void AnswerCall(int number, int targetNumber, CallStatus status, Guid id)
        {
            AnswerCallEvent(number, targetNumber, status, id);
        }
    }
}
