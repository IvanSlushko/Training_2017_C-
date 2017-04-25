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
                Console.WriteLine(line);

                if (line.Contains("CandyElement"))
                {
                    //Console.WriteLine("CandyElement");

                    Regex.Replace(line, @"\s+", ""); //убрал пробелы

                    String[] substrings = line.Split(',');//разделил на  подстроки

                    if (substrings.Length == 5)
                    {

                        gift.Add(variants[0].Build(
                            substrings[0],
                            Convert.ToInt32(substrings[1], 16),
                            Convert.ToInt32(substrings[2], 16),
                            Convert.ToInt32(substrings[3], 16),
                            Convert.ChangeType(substrings[4], typeof(TypeCandyElement))));

                    }

                    else Console.WriteLine("Битая строка!!!");
                }
                else if (line.Contains("ChocoElement"))
                {
                    Console.WriteLine("ChocoElement");
                }
                else if (line.Contains("WaffleElement"))
                {
                    Console.WriteLine("WaffleElement");
                }




                //String[] substrings = line.Split(',');

                //if (substrings.Length == 5)
                //{
                //    for (int i = 0; i < substrings.Length; i++)
                //    {
                //        var substring1 = Regex.Replace(substrings[i], @"\s+", "");
                //        Console.WriteLine(substring1);
                //    }

                //}
                //else Console.WriteLine("Битая строка!!!");





                //foreach (var substring in substrings)
                //{
                //    // Console.WriteLine(substring);!!!!!
                //    //убираю пробелы
                //    var substring1 = Regex.Replace(substring, @"\s+", "");
                //    int res;
                //    bool isInt = int.TryParse(substring1, out res);

                //    if (isInt == true)
                //    {
                //        Console.WriteLine("Цифра  {0}", res);
                //    }
                //    else
                //    {
                //        Console.WriteLine("Текст  {0}", substring1);
                //    }

                //    //bool IsDigit = substring.Length == substring.Where(c => char.IsDigit(c)).Count();
                //}




            }
        }

    }
}
