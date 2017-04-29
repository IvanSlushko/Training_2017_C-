using NewYearPresent.Creators;
using NewYearPresent.Enum;
using NewYearPresent.Gift;
using System;
using System.Text.RegularExpressions;
using static NewYearPresent.CandyElement;
using static NewYearPresent.ChocoElement;
using static NewYearPresent.WaffleElement;

namespace NewYearPresent.Extensions
{
    public static class SplitText
    {
        public static void Go()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Lines.txt");

            Creator[] variants = new Creator[3];
            variants[0] = new CandyElementCreator();
            variants[1] = new ChokoElementCreator();
            variants[2] = new WaffleElementCreator();
            IGift gift = new Gift.Gift();

            //TypeCandyElement p1, p2, p3;
            //Enum.TryParse<TypeCandyElement>("ChocolateCandy", out p1);
            //Enum.TryParse<CandyElement.TypeCandyElement>("DropCandy", out p2);
            //Enum.TryParse<CandyElement.TypeCandyElement>("Sweetmeat", out p3);
            //TypeChocoElement p4, p5, p6;
            //Enum.TryParse<ChocoElement.TypeChocoElement>("MilkChocolate", out p4);
            //Enum.TryParse<ChocoElement.TypeChocoElement>("PorousChocolate", out p5);
            //Enum.TryParse<ChocoElement.TypeChocoElement>("DarkChocolate", out p6);
            //TypeWaffleElement p7, p8;
            //Enum.TryParse<WaffleElement.TypeWaffleElement>("ChocolateWaffle", out p7);
            //Enum.TryParse<WaffleElement.TypeWaffleElement>("CreamyWafer", out p8);

            foreach (string line in lines)
            {

                Regex.Replace(line, @"\s+", "");           //убрал пробелы

                //if (line.Contains("ChocolateCandy"))
                //{
                //    var p = p1;
                //}
                //else if (line.Contains("DropCandy"))
                //{
                //    var p = p2;
                //}
                //else if (line.Contains("Sweetmeat"))
                //{
                //    var p = p3;
                //}
                //else if (line.Contains("MilkChocolate"))
                //{
                //    var p = p4;
                //}
                //else if (line.Contains("PorousChocolate"))
                //{
                //    var p = p5;
                //}
                //else if (line.Contains("DarkChocolate"))
                //{
                //    var p = p6;
                //}
                //else if (line.Contains("ChocolateWaffle"))
                //{
                //    var p = p7;
                //}
                //else if (line.Contains("CreamyWafer"))
                //{
                //    var p = p8;
                //}
                //else { Console.WriteLine("Битая строка или не содержит элементов!!!"); }

                //String[] substrings = line.Split(',');//разделил на  подстроки

                //if (substrings.Length == 5)
                //{

                //    gift.Add(variants[0].Build(substrings[0],
                //    Int32.Parse(substrings[1]),
                //    Int32.Parse(substrings[2]),
                //    Int32.Parse(substrings[3]), p));
                //}

////HERE
            //    if (line.Contains("ChocolateCandy"))
            //    {
            //        String[] substrings = line.Split(',');//разделил на  подстроки
            //        if (substrings.Length == 5)
            //        {
            //            gift.Add(variants[0].Build(substrings[0], Int32.Parse(substrings[1]),
            //            Int32.Parse(substrings[2]), Int32.Parse(substrings[3]), p1));
            //        }
            //        else Console.WriteLine("Битая строка!!!");
            //    }

            //    if (line.Contains("DropCandy"))
            //    {
            //        ;
            //        String[] substrings = line.Split(',');
            //        if (substrings.Length == 5)
            //        {
            //            gift.Add(variants[0].Build(substrings[0], Int32.Parse(substrings[1]),
            //            Int32.Parse(substrings[2]), Int32.Parse(substrings[3]), p2));
            //        }
            //        else Console.WriteLine("Битая строка!!!");
            //    }

            //    if (line.Contains("Sweetmeat"))
            //    {
            //        String[] substrings = line.Split(',');
            //        if (substrings.Length == 5)
            //        {
            //            gift.Add(variants[0].Build(substrings[0], Int32.Parse(substrings[1]),
            //            Int32.Parse(substrings[2]), Int32.Parse(substrings[3]), p3));
            //        }
            //        else Console.WriteLine("Битая строка!!!");
            //    }

            //    if (line.Contains("MilkChocolate"))
            //    {
            //        String[] substrings = line.Split(',');
            //        if (substrings.Length == 5)
            //        {
            //            gift.Add(variants[1].Build(substrings[0], Int32.Parse(substrings[1]),
            //            Int32.Parse(substrings[2]), Int32.Parse(substrings[3]), p4));
            //        }
            //        else Console.WriteLine("Битая строка!!!");
            //    }

            //    if (line.Contains("PorousChocolate"))
            //    {
            //        String[] substrings = line.Split(',');
            //        if (substrings.Length == 5)
            //        {
            //            gift.Add(variants[1].Build(substrings[0], Int32.Parse(substrings[1]),
            //            Int32.Parse(substrings[2]), Int32.Parse(substrings[3]), p5));
            //        }
            //        else Console.WriteLine("Битая строка!!!");
            //    }

            //    if (line.Contains("DarkChocolate"))
            //    {
            //        String[] substrings = line.Split(',');
            //        if (substrings.Length == 5)
            //        {
            //            gift.Add(variants[1].Build(substrings[0], Int32.Parse(substrings[1]),
            //            Int32.Parse(substrings[2]), Int32.Parse(substrings[3]), p6));
            //        }
            //        else Console.WriteLine("Битая строка!!!");
            //    }

            //    if (line.Contains("ChocolateWaffle"))
            //    {
            //        String[] substrings = line.Split(',');
            //        if (substrings.Length == 5)
            //        {
            //            gift.Add(variants[2].Build(substrings[0], Int32.Parse(substrings[1]),
            //            Int32.Parse(substrings[2]), Int32.Parse(substrings[3]), p7));
            //        }
            //        else Console.WriteLine("Битая строка!!!");
            //    }

            //    if (line.Contains("CreamyWafer"))
            //    {
            //        String[] substrings = line.Split(',');
            //        if (substrings.Length == 5)
            //        {
            //            gift.Add(variants[2].Build(substrings[0], Int32.Parse(substrings[1]),
            //            Int32.Parse(substrings[2]), Int32.Parse(substrings[3]), p8));
            //        }
            //        else Console.WriteLine("Битая строка!!!");
            //    }
            }

            Console.WriteLine("--------FROM FILE!! ------>");
            //gift.ToConsole();

            //gift.SortByWeight();
            //gift.ToConsole();
        }
    }
}

