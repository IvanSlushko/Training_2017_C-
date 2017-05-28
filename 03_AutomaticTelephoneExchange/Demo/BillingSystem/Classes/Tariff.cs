using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Classes
{
    public class Tariff
    {
        public decimal CostOfMonth { get; private set; }
        public decimal CostOfCallPerMinute { get; private set; }
        public TypeOffTariffPlan TypeOffTariffPlan { get; private set; }
        public Tariff(TypeOffTariffPlan type)
        {
            TypeOffTariffPlan = type;
            switch (TypeOffTariffPlan)
            {
                case TypeOffTariffPlan.SmartMini:
                    {
                        CostOfMonth = 10m;
                        CostOfCallPerMinute = 3m;
                        break;
                    }
                case TypeOffTariffPlan.Smart:
                    {
                        CostOfMonth = 20m;
                        CostOfCallPerMinute = 2m;
                        break;
                    }
                case TypeOffTariffPlan.SmartUnlim:
                    {
                        CostOfMonth = 30m;
                        CostOfCallPerMinute = 1m;
                        break;
                    }
                case TypeOffTariffPlan.Business:
                    {
                        CostOfMonth = 90m;
                        CostOfCallPerMinute = 1m;
                        break;
                    }
                default:
                    {
                        CostOfMonth = 0m;
                        CostOfCallPerMinute = 0m;
                        break;
                    }
            }
        }
    }
}
