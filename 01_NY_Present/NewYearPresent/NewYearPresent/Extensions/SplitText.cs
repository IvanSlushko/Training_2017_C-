using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

                Char delimiter = ',';
                String[] substrings = line.Split(delimiter);
                foreach (var substring in substrings)
                {
                    Console.WriteLine(substring);
                    int res;
                    bool isInt = Int32.TryParse(substring, out res);
                    Console.WriteLine(res+1);//!!!!!!!!!!!!!
                }

                Console.WriteLine(new string('-', 20));


                //if (line.Contains("CandyElement"))
                //{
                //    Console.WriteLine("конфета {0}", line);
                //    gift.Add(variants[0].Build(line as GiftElement));


                //}
                //else if (line.Contains("ChocoElement"))
                //{
                //    Console.WriteLine("шоколад {0}", line);
                //}
                //else if (line.Contains("WaffleElement"))
                //{
                //    Console.WriteLine("вафля {0}", line);
                //}
                //else Console.WriteLine("плохая строка {0}",line);
            }
        }

    }
}
