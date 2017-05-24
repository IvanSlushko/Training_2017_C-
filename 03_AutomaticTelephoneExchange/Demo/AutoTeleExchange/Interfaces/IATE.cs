using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillingSystem;
using BillingSystem.Classes;
using BillingSystem.Interfaces;
using AutoTeleExchange.Classes;

namespace AutoTeleExchange.Interfaces
{
    public interface IATE : IStorage<CallInfo>
    {
        Terminal GetNewTerminal(IContract contract);
        IContract RegisterContract(User user, TypeOffTariffPlan type);
        void CallingTo(object sender, ICallEvent e);
    }
}
