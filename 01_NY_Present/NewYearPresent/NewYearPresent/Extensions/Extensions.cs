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
        public static void ToConsole(this IGift element)
        {
            Console.WriteLine("Подарок: ");
            foreach (var p in element.Elements)
            {
                //     Имя | Вес | Сахар | Калории | Тип элемента
                Console.WriteLine("Элемент: {0}, имя: {1}, вес: {2}, сахар: {3}, калории: {4}"
                    ,p.GetType().Name
                    ,p.name
                    ,p.weight
                    ,p.sugar
                    ,p.calories);
               // yield return p;
            }
        }
        //    }
        //}


    }
}
