using NewYearPresent.Gift;
using System;
using System.Collections.Generic;

namespace NewYearPresent.Extensions
{
    public static class Extensions
    {
        public static void ToConsole(this IGift element)
        {
            Console.WriteLine("Подарок: ");
            foreach (var p in element.Elements)
            {
                Console.WriteLine("Элемент: {0}, имя: {1}, вес: {2}, сахар: {3}, калории: {4}"
                    , p.GetType().Name
                    , p.name
                    , p.weight
                    , p.sugar
                    , p.calories);
            }
            Console.WriteLine(new string('-', 75));
        }
    }
}
