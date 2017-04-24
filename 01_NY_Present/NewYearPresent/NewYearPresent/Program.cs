﻿using System;
using NewYearPresent.Gift;
using NewYearPresent.Creators;
using NewYearPresent.Elements;
using NewYearPresent.Extensions;

namespace NewYearPresent
{
    class Program
    {
        static void Main(string[] args)
        {

            Creator[] variants = new Creator[3];

            variants[0] = new CandyElementCreator();
            variants[1] = new ChokoElementCreator();
            variants[2] = new WaffleElementCreator();

            //     Имя | Вес | Сахар | Калории | Тип элемента

            IGift gift = new Gift.Gift();

            gift.Add(variants[0].Build("Конфета Мишка", 10, 15, 20, CandyElement.TypeCandyElement.ChocolateCandy));
            gift.Add(variants[0].Build("Конфета Мишка1", 11, 13, 5, CandyElement.TypeCandyElement.Sweetmeat));
            gift.Add(variants[0].Build("Конфета1", 8, 13, 1, CandyElement.TypeCandyElement.DropCandy));

            gift.Add(variants[1].Build("Milkа", 100, 13, 210, ChocoElement.TypeChocoElement.MilkChocolate));

            gift.Add(variants[2].Build("Вафля cream", 110, 15, 20, WaffleElement.TypeWaffleElement.CreamyWafer));
            gift.Add(variants[2].Build("Вафля komunarka", 170, 14, 22, WaffleElement.TypeWaffleElement.ChocolateWaffle));

            Console.WriteLine(new string('-', 75));
            gift.ToConsole();

            Console.WriteLine("Итого масса:              {0} гр.", gift.GiftWeight());
            Console.WriteLine("Калорий во всем подарке:  {0}.", gift.GiftSumCalories());
            Console.WriteLine(new string('-', 75));

            Console.WriteLine("SortByWeight:");
            gift.SortByWeight();
            gift.ToConsole();

            Console.WriteLine("SortByCalorie:");
            gift.SortByCalorie();
            gift.ToConsole();

            Console.WriteLine("FindBySugar:");
            gift.FindBySugar(0,14);
            gift.ToConsole();


            //var _FindBySugar = gift.FindBySugar(0, 14);

            // _FindBySugar.ToConsole();

            //foreach (var elements in gift.FindBySugar(0, 14))
            //{
            //    Console.WriteLine("Название конфеты: {0}, Сахар: {1}", elements.name, elements.sugar);
            //}

            Console.WriteLine("ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ");


            SplitText.Go();

        }
    }


}
