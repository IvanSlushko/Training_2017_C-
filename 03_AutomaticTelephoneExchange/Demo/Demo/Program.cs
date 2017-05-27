using AutoTeleExchange.Classes;
using AutoTeleExchange.Enums;
using AutoTeleExchange.Interfaces;
using BillingSystem;
using BillingSystem.Classes;
using BillingSystem.Interfaces;
using ReportCreat.Classes;
using ReportCreat.Interfaces;
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
            IReportCreator report = new ReportCreator();

            Console.WriteLine("Abonents: =>");

            IContract con1 = aTEx.RegisterContract(new User("Anton", "Goncharuk"), TypeOffTariffPlan.Business);
            IContract con2 = aTEx.RegisterContract(new User("Olga", "Gordeeva"), TypeOffTariffPlan.Smart);
            IContract con3 = aTEx.RegisterContract(new User("Alex", "Kulesh"), TypeOffTariffPlan.SmartUnlim);
            IContract con4 = aTEx.RegisterContract(new User("Misha", "Antonov"), TypeOffTariffPlan.SmartMini);

            con1.User.AddMoneyToAccount(7m);
            con4.User.AddMoneyToAccount(2m);

            Console.WriteLine(con1.User.FirstName + "  " + con1.User.LastName + "  " + con1.Number + " " + con1.Tariff.TypeOffTariffPlan + "  " + con1.User.Money);
            Console.WriteLine(con2.User.FirstName + "  " + con2.User.LastName + "  " + con2.Number + " " + con2.Tariff.TypeOffTariffPlan + "  " + con2.User.Money);
            Console.WriteLine(con3.User.FirstName + "  " + con3.User.LastName + "  " + con3.Number + " " + con3.Tariff.TypeOffTariffPlan + "  " + con3.User.Money);
            Console.WriteLine(con4.User.FirstName + "  " + con4.User.LastName + "  " + con4.Number + " " + con4.Tariff.TypeOffTariffPlan + "  " + con4.User.Money);
            Console.WriteLine(new string('=', 75));

            var ter1 = aTEx.NewTerminal(con1);
            var ter2 = aTEx.NewTerminal(con2);
            var ter3 = aTEx.NewTerminal(con3);
            var ter4 = aTEx.NewTerminal(con4);

            ter1.ConnectToPort();
            ter2.ConnectToPort();
            ter3.ConnectToPort();
            ter4.ConnectToPort();

            ter1.Call(ter2.Number);
           

            //ter2.EndCall();

            ter3.Call(ter1.Number);
            //ter1.EndCall();




            //Console.WriteLine("........");
            //ter3.EndCall();

            //ter2.Call(ter1.Number);
            //Console.WriteLine("........");
            //ter1.EndCall();

            //ter1.Call(ter4.Number);
            //ter4.EndCall();

            Console.WriteLine(new string('=', 75));
            Console.WriteLine(  "Report by number: {0}", ter1.Number);
            report.Create(bs.GetReport(ter1.Number), TypeOfSort.SortByDate);
            Console.WriteLine(new string('=', 75));


            //report.Create(bs.GetReport(ter1.Number), TypeOfSort.SortByCallType);
            //Console.WriteLine(new string('=', 75));
            //report.Create(bs.GetReport(ter1.Number), TypeOfSort.SortByNumber);
            //Console.WriteLine(new string('=', 75));
            //report.Create(bs.GetReport(ter1.Number), TypeOfSort.SortByCost);
            //Console.WriteLine(new string('=', 75));

    // PRICE^^

        }
    }
}
