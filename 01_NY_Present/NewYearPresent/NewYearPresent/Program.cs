using System;
using NewYearPresent.Gift;
using NewYearPresent.Creators;
using NewYearPresent.Elements;

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
            gift.Add(variants[0].Build("Конфета Мишка1", 10, 13, 1, CandyElement.TypeCandyElement.Sweetmeat));
            gift.Add(variants[0].Build("Конфета1", 10, 13, 1, CandyElement.TypeCandyElement.DropCandy));

            gift.Add(variants[1].Build("Milkа", 100, 13, 210, ChocoElement.TypeChocoElement.MilkChocolate));

            gift.Add(variants[2].Build("Vaffle cream", 103, 15, 20, WaffleElement.TypeWaffleElement.CreamyWafer ));
            gift.Add(variants[2].Build("Vaffle komunarka", 170, 14, 20, WaffleElement.TypeWaffleElement.ChocolateWaffle));

            foreach (var i in gift.Elements) 
            {
                Console.WriteLine("element : {0}, weigth: {1}, sugar: {2}, cal: {3},  TYPE: {4} "
                    , i.name, i.weight, i.sugar, i.calories, i.GetType().Name);

            }

        }
    }
}
