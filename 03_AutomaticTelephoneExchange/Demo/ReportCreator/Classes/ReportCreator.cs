using AutoTeleExchange.Enums;
using ReportCreat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportCreat.Classes
{
    public class ReportCreator : IReportCreator
    {

        private IEnumerable<ReportEvent> repo;

        public ReportCreator() { }

        public void Create(Report report, TypeOfSort sortType)
        {
            switch (sortType)
            {
                case TypeOfSort.SortByCallType:
                    repo = SortByCallType(report);
                    break;
                case TypeOfSort.SortByDate:
                    repo = SortByDate(report);
                    break;
                case TypeOfSort.SortByCost:
                    repo = SortByCost(report);
                    break;
                case TypeOfSort.SortByNumber:
                    repo = SortByNumber(report);
                    break;
            }

            foreach (var item in repo)
            {
                Console.WriteLine("=> {0}, {1}, {2}, opponent: {3}, price: {4}",
                       item.CallType,
                       item.Time.ToString("mm:ss"),
                       item.Date,
                       item.Number,
                       decimal.Round(item.Cost,2));
            }
        }

        public IEnumerable<ReportEvent> SortByCallType(Report report)
        {
            var rep = report.GetRecords();
            return rep = rep.OrderBy(x => x.CallType).ToList();
        }

        public IEnumerable<ReportEvent> SortByCost(Report report)
        {
            var rep = report.GetRecords();
            return rep = rep.OrderBy(x => x.Cost).ToList();
        }

        public IEnumerable<ReportEvent> SortByDate(Report report)
        {
            var rep = report.GetRecords();
            return rep = rep.OrderBy(x => x.Date).ToList();
        }

        public IEnumerable<ReportEvent> SortByNumber(Report report)
        {
            var rep = report.GetRecords();
            return rep = rep.OrderBy(x => x.Number).ToList();
        }

        public IEnumerable<ReportEvent> sortType(Report report)
        {
            throw new NotImplementedException();
        }
    }
}
