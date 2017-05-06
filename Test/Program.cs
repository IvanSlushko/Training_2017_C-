using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TextHandler.Parsers;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Инициализирует новый экземпляр класса StreamReader для заданного потока, 
            //используя указанную кодировку символов. (default)
            var streamReader = new StreamReader(@"..\..\SourceFile\TextFile.txt", Encoding.Default);
            var parser = new TextParser();
            var text = parser.Parse(streamReader);

            Console.WriteLine(new string('-', 75));

            foreach (var sentence in text.Sentences)
            {
                Console.WriteLine(sentence.SentenceToString());
                Console.WriteLine("=> {0}", sentence.Items.Count);
            }












        }
    }
}

