using BillingSystem.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Interfaces
{
    public interface IContract
    {
        User User { get; }
        int Number { get; }
        Tariff Tariff { get; }
        bool ChangeTariff(TypeOffTariffPlan typeOffTariffPlan);
    }
}
