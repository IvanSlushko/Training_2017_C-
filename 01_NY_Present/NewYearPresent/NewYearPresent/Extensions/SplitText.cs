using NewYearPresent.Creators;
using NewYearPresent.Gift;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static NewYearPresent.CandyElement;

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

            foreach (string line in lines)
            {
                TypeCandyElement p1, p2, p3;
                Enum.TryParse<CandyElement.TypeCandyElement>("ChocolateCandy", out p1);
                Enum.TryParse<CandyElement.TypeCandyElement>("DropCandy", out p2);
                Enum.TryParse<CandyElement.TypeCandyElement>("Sweetmeat", out p3);

                if (line.Contains("ChocolateCandy"))
                {
                    Regex.Replace(line, @"\s+", ""); //убрал пробелы
                    String[] substrings = line.Split(',');//разделил на  подстроки
                    if (substrings.Length == 5)
                    {
                        gift.Add(variants[0].Build(substrings[0],
                            Convert.ToInt32(substrings[1], 16), Convert.ToInt32(substrings[2], 16),
                            Convert.ToInt32(substrings[3], 16), p1));

                    }

                    else Console.WriteLine("Битая строка!!!");
                }
                else if (line.Contains("ChocoElement"))
                {
                    // Console.WriteLine("ChocoElement");
                }
                else if (line.Contains("WaffleElement"))
                {
                    //Console.WriteLine("WaffleElement");
                }


            }
            Console.WriteLine("-------- FILE INPUT!! ------>");
            gift.ToConsole();
        }

    }
}
