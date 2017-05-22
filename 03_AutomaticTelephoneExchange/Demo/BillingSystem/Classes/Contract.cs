using BillingSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Classes
{
    public class Contract : IContract
    {
        Random random = new Random();
        private DateTime ChangeTarifDate;

        public User User { get; private set; }
        public int Number { get; private set; }
        public TypeOffTariffPlan typeOffTariffPlan { get; private set; }
        public Tariff Tariff { get; private set; }

        public Contract(User user, TypeOffTariffPlan typeOffTariffPlan)
        {
            ChangeTarifDate = DateTime.Now;
            User = user;
            Number = Convert.ToInt32("29" + random.Next(7000000, 7999999));
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
                Console.WriteLine("You can not change the tariff if the month has not passed!");
                return false;
            }
        }
    }
}
