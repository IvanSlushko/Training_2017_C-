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


            IATE aTEx = new ATE();
            IBillingSystem bs = new BillingSys(aTEx);

            Console.WriteLine("Abonents: =>");

            IContract con1 = aTEx.RegisterContract(new User("Anton", "Goncharuk"), TypeOffTariffPlan.Business);
            IContract con2 = aTEx.RegisterContract(new User("Olga", "Gordeeva"), TypeOffTariffPlan.Smart);
            IContract con3 = aTEx.RegisterContract(new User("Alex", "Kulesh"), TypeOffTariffPlan.SmartUnlim);
            IContract con4 = aTEx.RegisterContract(new User("Misha", "Antonov"), TypeOffTariffPlan.SmartMini);

            con1.User.AddMoneyToAccount(7);
            con4.User.AddMoneyToAccount(2);

            Console.WriteLine(con1.User.FirstName + "  " + con1.User.LastName + "  " + con1.Number + " " + con1.Tariff.TypeOffTariffPlan + "  " + con1.User.Money);
            Console.WriteLine(con2.User.FirstName + "  " + con2.User.LastName + "  " + con2.Number + " " + con2.Tariff.TypeOffTariffPlan + "  " + con2.User.Money);
            Console.WriteLine(con3.User.FirstName + "  " + con3.User.LastName + "  " + con3.Number + " " + con3.Tariff.TypeOffTariffPlan + "  " + con3.User.Money);
            Console.WriteLine(con4.User.FirstName + "  " + con4.User.LastName + "  " + con4.Number + " " + con4.Tariff.TypeOffTariffPlan + "  " + con4.User.Money);
            Console.WriteLine(new string('-', 40));








            //var ter1 = aTEx.GetNewTerminal(con1);
            //var ter2 = aTEx.GetNewTerminal(con2);
            //var ter3 = aTEx.GetNewTerminal(con3);
            //var ter4 = aTEx.GetNewTerminal(con4);

            //ter1.ConnectToPort();
            //Console.WriteLine(ter1.Number );



        }
    }
}
