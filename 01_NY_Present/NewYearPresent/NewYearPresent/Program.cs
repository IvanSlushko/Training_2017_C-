using System;
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


            string[] lines = System.IO.File.ReadAllLines(@"C:\Lines.txt");
            foreach (string line in lines)
            {

                if (line.Contains("CandyElement"))
                {
                    Console.WriteLine("конфета {0}", line);
                    //gift.Add(variants[0].Build(line as GiftElement));
                }
                else if (line.Contains("ChocoElement"))
                {
                    Console.WriteLine("шоколад {0}", line);
                }
                else if (line.Contains("WaffleElement"))
                {
                    Console.WriteLine("вафля {0}", line);
                }
                else Console.WriteLine("плохая строка {0}",line);
            }


            Console.WriteLine(new string('-', 75));
            gift.ToConsole();

            Console.WriteLine("Итого масса:              {0} гр.", gift.GiftWeight());
            Console.WriteLine("Калорий во всем подарке:  {0}.", gift.GiftSumCalories());
            Console.WriteLine(new string('-', 75));
           // ReadFromFile.Go();


        }
    }

    //class ReadFromFile
    //{
    //    public static void Go()
    //    {
    //        // Example #1
    //        // Read the file as one string.
    //        string text = System.IO.File.ReadAllText(@"C:\Text.txt");

    //        // Display the file contents to the console. Variable text is a string.
    //        Console.WriteLine("Contents of Text.txt_________________");
    //        System.Console.WriteLine(text);

    //        // Example #2
    //        // Read each line of the file into a string array. Each element
    //        // of the array is one line of the file.
    //        string[] lines = System.IO.File.ReadAllLines(@"C:\Lines.txt");

    //        // Display the file contents by using a foreach loop.
    //        System.Console.WriteLine("Contents of Lines.txt__________________");
    //        foreach (string line in lines)
    //        {
    //            Console.WriteLine(line);
    //        }

    //        // Keep the console window open in debug mode.
    //        Console.WriteLine("Press any key to exit.");
    //        System.Console.ReadKey();
    //    }
    //}



}
