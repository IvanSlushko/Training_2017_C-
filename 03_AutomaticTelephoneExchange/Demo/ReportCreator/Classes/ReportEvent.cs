using AutoTeleExchange.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportCreat.Classes
{
   public class ReportEvent
    {
        public CallType CallType { get; private set; }
        public int Number { get; private set; }
        public DateTime Date { get; private set; }
        public DateTime Time { get; private set; }
        public decimal Cost { get; private set; }

        public ReportEvent(CallType callType, int number, DateTime date, DateTime time, decimal cost)
        {
            CallType = callType;
            Number = number;
            Date = date;
            Time = time;
            Cost = cost;
        }
    }
}
