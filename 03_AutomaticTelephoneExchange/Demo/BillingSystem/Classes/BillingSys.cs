using AutoTeleExchange.Classes;
using AutoTeleExchange.Enums;
using AutoTeleExchange.Interfaces;
using BillingSystem.Interfaces;
using ReportCreat.Classes;
using System;
using System.Linq;

namespace BillingSystem.Classes
{
    public class BillingSys : IBillingSystem
    {

        private IStorage<CallInfo> _storage;

        public BillingSys(IStorage<CallInfo> storage)
        {
            _storage = storage;
        }

        public Report GetReport(int telephoneNumber)
        {
            var calls = _storage.GetInfoList().Where(x => x.SourceNumber == telephoneNumber || x.TargetNumber == telephoneNumber).ToList();
            var report = new Report();

            foreach (var call in calls)
            {
                CallType callType;
                int number;
                if (call.SourceNumber == telephoneNumber)
                {
                    callType = CallType.OutgoingCall;
                    number = call.TargetNumber;
                }
                else
                {
                    callType = CallType.IncomingCall;
                    number = call.SourceNumber;
                }

                var record = new ReportEvent(callType, number, call.StartCall, new DateTime((call.EndCall - call.StartCall).Ticks), call.Cost);
                report.AddRecord(record);
            }
            return report;
        }
    }
}
