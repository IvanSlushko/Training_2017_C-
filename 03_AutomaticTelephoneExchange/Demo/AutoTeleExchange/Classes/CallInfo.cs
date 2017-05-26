using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTeleExchange.Classes
{
    public class CallInfo
    {
        public Guid Id { get; set; }
        public int SourceNumber { get; set; }
        public int TargetNumber { get; set; }
        public DateTime StartCall { get; set; }
        public DateTime EndCall { get; set; }
        public decimal Cost { get; set; }

        public CallInfo(int sourceNumber, int targetNumber, DateTime startCall)
        {
            Id = Guid.NewGuid();
            SourceNumber = sourceNumber;
            TargetNumber = targetNumber;
            StartCall = startCall;
        }
    }
}
