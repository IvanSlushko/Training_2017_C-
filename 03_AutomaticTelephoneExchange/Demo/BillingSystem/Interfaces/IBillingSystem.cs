using ReportCreat.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Interfaces
{
    public interface IBillingSystem
    {
        Report GetReport(int telephoneNumber);
    }
}
