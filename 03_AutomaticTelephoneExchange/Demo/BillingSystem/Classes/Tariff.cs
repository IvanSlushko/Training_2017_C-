using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Classes
{
    public class Tariff
    {
        public int CostOfMonth { get; private set; }
        public int CostOfCallPerMinute { get; private set; }
        public int LimitCallInMonth { get; private set; }
        public TypeOffTariffPlan TypeOffTariffPlan { get; private set; }
        public Tariff(TypeOffTariffPlan type)
        {
            TypeOffTariffPlan = type;
            switch (TypeOffTariffPlan)
            {
                case TypeOffTariffPlan.SmartMini:
                    {
                        CostOfMonth = 10;
                        LimitCallInMonth = 4;
                        CostOfCallPerMinute = 3;
                        break;
                    }
                case TypeOffTariffPlan.Smart:
                    {
                        CostOfMonth = 20;
                        LimitCallInMonth = 8;
                        CostOfCallPerMinute = 2;
                        break;
                    }
                case TypeOffTariffPlan.SmartUnlim:
                    {
                        CostOfMonth = 30;
                        LimitCallInMonth = 20;
                        CostOfCallPerMinute = 1;
                        break;
                    }
                case TypeOffTariffPlan.Business:
                    {
                        CostOfMonth = 40;
                        LimitCallInMonth = 30;
                        CostOfCallPerMinute = 1;
                        break;
                    }
                default:
                    {
                        CostOfMonth = 0;
                        LimitCallInMonth = 0;
                        CostOfCallPerMinute = 0;
                        break;
                    }
            }
        }
    }
}
