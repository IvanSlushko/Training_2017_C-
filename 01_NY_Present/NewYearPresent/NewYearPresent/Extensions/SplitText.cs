using NewYearPresent.Creators;
using NewYearPresent.Gift;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NewYearPresent.Extensions
{
    public static class SplitText
    {
        public static void Go()
        {

            string[] lines = System.IO.File.ReadAllLines(@"C:\Lines.txt");

            foreach (string line in lines)
            {

                Console.WriteLine(line);
                //Console.WriteLine(line.Length);

               

                Creator[] variants = new Creator[3];
                variants[0] = new CandyElementCreator();
                variants[1] = new ChokoElementCreator();
                variants[2] = new WaffleElementCreator();

                Char delimiter = ',';
                String[] substrings = line.Split(delimiter);

                IGift gift = new Gift.Gift();

                foreach (var substring in substrings)
                {
                    // Console.WriteLine(substring);

                    //убираю пробелы
                    var substring1 = Regex.Replace(substring, @"\s+", "");

                    int res;
                    bool isInt = int.TryParse(substring1, out res);

                    if (isInt == true) {
                        Console.WriteLine("Цифра  {0}", res);

                    }
                    else
                    {
                        Console.WriteLine("Текст  {0}", substring1);
                    }




                    //bool IsDigit = substring.Length == substring.Where(c => char.IsDigit(c)).Count();



                    //    int[] matches = Regex.Matches(substring, "\\d+")
                    //.Cast<Match>()
                    //.Select(x => int.Parse(x.Value))
                    //.ToArray();
                    //    foreach (int match in matches)
                    //        Console.WriteLine(match);

                }

                Console.WriteLine(new string('-', 20));


            }
        }

    }
}
