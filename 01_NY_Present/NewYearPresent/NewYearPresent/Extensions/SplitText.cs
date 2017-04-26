using NewYearPresent.Creators;
using NewYearPresent.Elements;
using NewYearPresent.Gift;
using System;
using System.Text.RegularExpressions;
using static NewYearPresent.CandyElement;
using static NewYearPresent.ChocoElement;
using static NewYearPresent.Elements.WaffleElement;

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

            TypeCandyElement p1, p2, p3;
            Enum.TryParse<CandyElement.TypeCandyElement>("ChocolateCandy", out p1);
            Enum.TryParse<CandyElement.TypeCandyElement>("DropCandy", out p2);
            Enum.TryParse<CandyElement.TypeCandyElement>("Sweetmeat", out p3);
            TypeChocoElement p4, p5, p6;
            Enum.TryParse<ChocoElement.TypeChocoElement>("MilkChocolate", out p4);
            Enum.TryParse<ChocoElement.TypeChocoElement>("PorousChocolate", out p5);
            Enum.TryParse<ChocoElement.TypeChocoElement>("DarkChocolate", out p6);
            TypeWaffleElement p7, p8;
            Enum.TryParse<WaffleElement.TypeWaffleElement>("ChocolateWaffle", out p7);
            Enum.TryParse<WaffleElement.TypeWaffleElement>("CreamyWafer", out p8);

            foreach (string line in lines)
            {

                if (line.Contains("ChocolateCandy"))
                {
                    Regex.Replace(line, @"\s+", "");           //убрал пробелы
                    String[] substrings = line.Split(',');//разделил на  подстроки
                    if (substrings.Length == 5)
                    {
                        gift.Add(variants[0].Build(substrings[0],
                        Convert.ToInt32(substrings[1], 16),
                        Convert.ToInt32(substrings[2], 16),
                        Convert.ToInt32(substrings[3], 16), p1));
                    }
                    else Console.WriteLine("Битая строка!!!");
                }

                if (line.Contains("DropCandy"))
                {
                    Regex.Replace(line, @"\s+", "");           //убрал пробелы
                    String[] substrings = line.Split(',');//разделил на  подстроки
                    if (substrings.Length == 5)
                    {
                        gift.Add(variants[0].Build(substrings[0],
                        Convert.ToInt32(substrings[1], 16),
                        Convert.ToInt32(substrings[2], 16),
                        Convert.ToInt32(substrings[3], 16), p2));
                    }
                    else Console.WriteLine("Битая строка!!!");
                }

                if (line.Contains("Sweetmeat"))
                {
                    Regex.Replace(line, @"\s+", "");           //убрал пробелы
                    String[] substrings = line.Split(',');//разделил на  подстроки
                    if (substrings.Length == 5)
                    {
                        gift.Add(variants[0].Build(substrings[0],
                        Convert.ToInt32(substrings[1], 16),
                        Convert.ToInt32(substrings[2], 16),
                        Convert.ToInt32(substrings[3], 16), p3));
                    }
                    else Console.WriteLine("Битая строка!!!");
                }

                if (line.Contains("MilkChocolate"))
                {
                    Regex.Replace(line, @"\s+", "");           //убрал пробелы
                    String[] substrings = line.Split(',');//разделил на  подстроки
                    if (substrings.Length == 5)
                    {
                        gift.Add(variants[1].Build(substrings[0],
                        Convert.ToInt32(substrings[1], 16),
                        Convert.ToInt32(substrings[2], 16),
                        Convert.ToInt32(substrings[3], 16), p4));
                    }
                    else Console.WriteLine("Битая строка!!!");
                }

                if (line.Contains("PorousChocolate"))
                {
                    Regex.Replace(line, @"\s+", "");           //убрал пробелы
                    String[] substrings = line.Split(',');//разделил на  подстроки
                    if (substrings.Length == 5)
                    {
                        gift.Add(variants[1].Build(substrings[0],
                        Convert.ToInt32(substrings[1], 16),
                        Convert.ToInt32(substrings[2], 16),
                        Convert.ToInt32(substrings[3], 16), p5));
                    }
                    else Console.WriteLine("Битая строка!!!");
                }

                if (line.Contains("DarkChocolate"))
                {
                    Regex.Replace(line, @"\s+", "");           //убрал пробелы
                    String[] substrings = line.Split(',');//разделил на  подстроки
                    if (substrings.Length == 5)
                    {
                        gift.Add(variants[1].Build(substrings[0],
                        Convert.ToInt32(substrings[1], 16),
                        Convert.ToInt32(substrings[2], 16),
                        Convert.ToInt32(substrings[3], 16), p6));
                    }
                    else Console.WriteLine("Битая строка!!!");
                }

                //if (line.Contains("ChocolateWaffle"))
                //{
                //    Regex.Replace(line, @"\s+", "");           //убрал пробелы
                //    String[] substrings = line.Split(',');//разделил на  подстроки
                //    if (substrings.Length == 5)
                //    {
                //        gift.Add(variants[2].Build(substrings[0],
                //        Convert.ToInt32(substrings[1], 16),
                //        Convert.ToInt32(substrings[2], 16),
                //        Convert.ToInt32(substrings[3], 16), p7));
                //    }
                //    else Console.WriteLine("Битая строка!!!");
                //}

                //if (line.Contains("CreamyWafer"))
                //{
                //    Regex.Replace(line, @"\s+", "");           //убрал пробелы
                //    String[] substrings = line.Split(',');//разделил на  подстроки
                //    if (substrings.Length == 5)
                //    {
                //        gift.Add(variants[2].Build(substrings[0],
                //        Convert.ToInt32(substrings[1], 16),
                //        Convert.ToInt32(substrings[2], 16),
                //        Convert.ToInt32(substrings[3], 16), p8));
                //    }
                //    else Console.WriteLine("Битая строка!!!");
                //}
            }
            Console.WriteLine("-------- FILE INPUT!! ------>");
            gift.ToConsole();
        }
    }
}

