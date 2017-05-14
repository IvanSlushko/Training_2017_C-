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

            //Выводим весь текст
            Console.WriteLine(new string('-', 75));
            foreach (var sentence in text.Sentences)
            {
                Console.WriteLine(sentence.SentenceToString());
                Console.WriteLine("=> {0}", sentence.Items.Count);
            }

            //Сортируем по возрастанию количества компонентов тредложения
            Console.WriteLine(new string('-', 75));
            foreach (var sentence in text.SortByAscending())
            {
                Console.WriteLine(sentence.SentenceToString());
                Console.WriteLine("=> {0}", sentence.Items.Count);
            }

            //Получить слова заданной длинны из вопросительных предложений (без повторений)
            Console.WriteLine(new string('-', 75));
            foreach (var word in text.GetWordsGivenLength(4))
            { Console.WriteLine(word.Chars); }

            //Удалить слова на согласную заданной длинны
            Console.WriteLine(new string('-', 75));
            text.DeleteConsonantsWords(10);
            Console.WriteLine(text.TextOut());

            //В некотором предложении текста слова заданной длины заменить указанной подстрокой.
            Console.WriteLine(new string('-', 75));
            // Номер предложеиня\длинна слова\вставляемая строка
            text.ReplaceSubstring(0, 5, "XXXxxx, yy YYYYY: Yyyy zZZzz", parser.ParseSentence);
            Console.WriteLine(text.TextOut());


            //var streamReader1 = new StreamReader(@"..\..\SourceFile\TextFile1.txt", Encoding.Default);
            //var parser1 = new TextParser();
            //var text1 = parser1.Parse(streamReader1);
            //Console.WriteLine(new string('-', 75));
            //foreach (var sentence in text1.Sentences)
            //{ Console.WriteLine(sentence.SentenceToString()); }
            //foreach (var word in text1.GetWordsGivenLength(4))
            //{ Console.WriteLine(word.Chars); }
        }
    }
}

