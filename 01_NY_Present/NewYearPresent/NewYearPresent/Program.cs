using System;
using NewYearPresent.Gift;
using NewYearPresent.Creator;

namespace NewYearPresent
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator.Creator[] variants = new Creator.Creator[3];
            variants[0] = new CandyElementCreator();

            //     Имя | Вес | Сахар | Калории | Тип элемента

            variants[0].BuildCandy("Конфета Мишка", 10, 15, 20, CandyElement.TypeCandyElement.ChocolateCandy);
            variants[0].BuildCandy("Конфета Мишка1", 10, 13, 1, CandyElement.TypeCandyElement.Sweetmeat);
            variants[0].BuildCandy("Конфета1", 10, 13, 1, CandyElement.TypeCandyElement.DropCandy);

            IGift gift = new Gift.Gift();






        }
    }
}
