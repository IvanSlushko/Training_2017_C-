using BillingSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BillingSystem.Classes
{
    public class Contract : IContract
    {
        RandomGenerator random = new RandomGenerator();
        private DateTime ChangeTarifDate;

        public User User { get; private set; }
        public int Number { get; private set; }
        public TypeOffTariffPlan typeOffTariffPlan { get; private set; }
        public Tariff Tariff { get; private set; }

        public Contract(User user, TypeOffTariffPlan typeOffTariffPlan)
        {
            ChangeTarifDate = DateTime.Now;
            User = user;
            Number = random.GetRandom(7000000, 7999999);
            Tariff = new Tariff(typeOffTariffPlan);
        }

        public bool ChangeTariff(TypeOffTariffPlan typeOffTariffPlan)
        {
            if (DateTime.Now.AddMonths(-1) >= ChangeTarifDate)
            {
                ChangeTarifDate = DateTime.Now;
                Tariff = new Tariff(typeOffTariffPlan);
                Console.WriteLine("Tariff changed!");
                return true;
            }
            else
            {
                Console.WriteLine("You can hange tariff once in month !");
                return false;
            }
        }
    }
}
