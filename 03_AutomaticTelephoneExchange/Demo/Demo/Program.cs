using AutoTeleExchange.Classes;
using AutoTeleExchange.Interfaces;
using BillingSystem;
using BillingSystem.Classes;
using BillingSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abonents:           Press 4 =>");
            IContract con1 = new Contract(new User("Anton", "Goncharuk"), TypeOffTariffPlan.Business);
            Console.ReadKey();
            IContract con2 = new Contract(new User("Olga", "Gordeeva"), TypeOffTariffPlan.Smart);
            Console.ReadKey();
            IContract con3 = new Contract(new User("Alex", "Kulesh"), TypeOffTariffPlan.SmartUnlim);
            Console.ReadKey();
            IContract con4 = new Contract(new User("Misha", "Antonov"), TypeOffTariffPlan.SmartMini);
            Console.ReadKey();

            //TODO  почему номера не рандомит???????????

            Console.WriteLine(con1.User.FirstName + "  " + con1.User.LastName + "  " + con1.Number + " " + con1.Tariff.TypeOffTariffPlan + "  " + con1.User.Money);
            Console.WriteLine(con2.User.FirstName + "  " + con2.User.LastName + "  " + con2.Number + " " + con2.Tariff.TypeOffTariffPlan + "  " + con2.User.Money);
            Console.WriteLine(con3.User.FirstName + "  " + con3.User.LastName + "  " + con3.Number + " " + con3.Tariff.TypeOffTariffPlan + "  " + con3.User.Money);
            Console.WriteLine(con4.User.FirstName + "  " + con4.User.LastName + "  " + con4.Number + " " + con4.Tariff.TypeOffTariffPlan + "  " + con4.User.Money);
            Console.WriteLine(new string('-', 40));

            IATE ate = new ATE();
            IBillingSystem bs = new BillingSystem.BillingSystem(ate);







        }
    }
}
