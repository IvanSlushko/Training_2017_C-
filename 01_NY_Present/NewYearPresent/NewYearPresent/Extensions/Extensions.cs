using NewYearPresent.Gift;
using System;
using System.Collections.Generic;

namespace NewYearPresent.Extensions
{
    public static class Extensions
    {

        //    namespace ConsoleApplication8
        //{    ПРИМЕР ВЫВОДА урок про лямбда и линк
        //    public static class Extensions
        //    {
        public static void ToConsole<T>(this IGift element)
        {
            Console.WriteLine("Подарок: ");
            foreach (var p in element.Elements)
            {
                Console.WriteLine(p.name);
                yield return p;
            }
        }
        //    }
        //}


    }
}
