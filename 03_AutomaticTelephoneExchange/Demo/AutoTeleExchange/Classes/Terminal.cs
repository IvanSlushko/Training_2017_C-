using AutoTeleExchange.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTeleExchange.Classes
{
    public class Terminal
    {

        private int phoneNumber;
        private Port terminalPort;
        private Guid id;
        public event EventHandler<CallEvent> CallEvent;
        public event EventHandler<AnswerEvent> AnswerEvent;
        public event EventHandler<EndCallEvent> EndCallEvent;

        public int Number
        {
            get
            {
                return phoneNumber;
            }
        }

        public Terminal(int number, Port port)
        {
            phoneNumber = number;
            terminalPort = port;
        }

        public void Call(int targetNumber)
        {
            UpCallEvent(targetNumber);
        }
        public void EndCall()
        {
            UpEndCallEvent(id);
        }

        protected virtual void UpCallEvent(int targetNumber)
        {
            CallEvent?.Invoke(this, new CallEvent(phoneNumber, targetNumber));
        }
        protected virtual void UpAnswerEvent(int targetNumber, CallStatus status, Guid id)
        {
            AnswerEvent?.Invoke(this, new AnswerEvent(phoneNumber, targetNumber, status, id));
        }
        protected virtual void UpEndCallEvent(Guid id)
        {
            EndCallEvent?.Invoke(this, new EndCallEvent(id, phoneNumber));
        }


        public void TakeIncomingCall(object sender, CallEvent e)
        {
            id = e.Id;
            Console.WriteLine("   Call from {0} to {1}", e.TelephoneNumber, e.TargetTelephoneNumber);
            Console.WriteLine("   Answer? Y/N");
            lable1:
            char key = Console.ReadKey().KeyChar;

            if (key == 'Y' || key == 'y')
            {
                AnswerToCall(e.TelephoneNumber, CallStatus.Answered, e.Id);
            }
            else if (key == 'N' || key == 'n')
            {
                Console.WriteLine();
                EndCall();
            }
            else
            {
                Console.WriteLine("  Wrong key, repeat input:");
                goto lable1;
            }
        }


        public void ConnectToPort()
        {
            if (terminalPort.Connect(this))
            {
                terminalPort.CallPortEvent += TakeIncomingCall;
                terminalPort.AnswerPortEvent += TakeAnswer;
            }
        }
        public void DisconnectFromPort()
        {
            if (terminalPort.Disconnect(this))
            {
                terminalPort.Disconnect(this);
            }
        }

        public void AnswerToCall(int target, CallStatus status, Guid id)
        {
            UpAnswerEvent(target, status, id);
        }

        public void TakeAnswer(object sender, AnswerEvent e)
        {
            id = e.Id;
            if (e.InCall == CallStatus.Answered)
            {
                Console.WriteLine("  {0}{0}{0} Go dialog: from {2} to {1}, at the end click any button.....", ((char)'\u25BA'), e.TelephoneNumber, e.TargetTelephoneNumber);
                Console.ReadKey();
                EndCall();
            }
            else if (e.InCall == CallStatus.Rejected)
            {
                Console.WriteLine("  {0}{0}{0} Rejected!", ((char)'\u25BA'));
            }
        }

    }
}

