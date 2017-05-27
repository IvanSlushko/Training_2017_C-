using AutoTeleExchange.Enums;
using ReportCreat.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportCreat.Interfaces
{
    public interface IReportCreator
    {
        void Create(Report report, TypeOfSort sortType);
        IEnumerable<ReportEvent> SortByDate(Report report);
        IEnumerable<ReportEvent> SortByCost(Report report);
        IEnumerable<ReportEvent> SortByNumber(Report report);
        IEnumerable<ReportEvent> SortByCallType(Report report);
    }
}
