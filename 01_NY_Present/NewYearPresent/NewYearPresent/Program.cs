using System;
using NewYearPresent.Gift;
using NewYearPresent.Creator;

namespace NewYearPresent
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creator[] qqq = new Creator[3];

            Creator.Creator[] variants = new Creator.Creator[3];
            variants[0] = new CandyElementCreator();

            //     Имя | Вес | Сахар | Калории | Тип элемента


            IGift gift = new Gift.Gift();

            gift.Add(variants[0].Build("Конфета Мишка", 10, 15, 20, CandyElement.TypeCandyElement.ChocolateCandy));
            gift.Add(variants[0].Build("Конфета Мишка1", 10, 13, 1, CandyElement.TypeCandyElement.Sweetmeat));
            gift.Add(variants[0].Build("Конфета1", 10, 13, 1, CandyElement.TypeCandyElement.DropCandy));


            foreach (var i in gift.Elements)
            {
                Console.WriteLine("element : {0}, weith: {1}, sugar: {2}, cal: {3}, "
                    , i.name, i.weith, i.sugar, i.calories);

            }

        }
    }
}
