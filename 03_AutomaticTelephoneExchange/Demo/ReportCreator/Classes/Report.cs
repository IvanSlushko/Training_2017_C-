using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportCreat.Classes
{
    public class Report
    {
        private IList<ReportEvent> listEvents;

        public Report()
        {
            listEvents = new List<ReportEvent>();
        }

        public void AddRecord(ReportEvent @event)
        {
            listEvents.Add(@event);
        }
        public IList<ReportEvent> GetRecords()
        {
            return listEvents;
        }
    }
}
