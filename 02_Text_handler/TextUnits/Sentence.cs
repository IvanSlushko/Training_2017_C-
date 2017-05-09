using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextHandler.Interfaces;
using TextHandler.Parsers;

namespace TextHandler.TextUnits
{
    public class Sentence : ISentence
    {
        private int _index;

        public Sentence()
        { Items = new List<ISentenceItem>(); }

        public IList<ISentenceItem> Items { get; }// private set; }

        public Sentence(IEnumerable<ISentenceItem> items) : this()
        {
            foreach (var item in items)
            { Items.Add(item); }
        }



        public string SentenceToString()
        {
            var strBuilder = new StringBuilder();
            GlueWords(-1, strBuilder);
            return strBuilder.ToString();
        }


        private void GlueWords(int index, StringBuilder strBuilder)
        {
            _index = index;

            while (true)
            {
                _index++;
                if (_index >= Items.Count) break;

                strBuilder.Append(Items[_index].Chars);
                var nextElement = Items.ElementAtOrDefault(_index + 1);

                if (nextElement == null) continue;

                if (Separator.SentenceSeparators.Contains(Items[_index].Chars) ||   //после точки пробел (т. к.)
                    Separator.InnerSeparator.Contains(nextElement.Chars) ||         //перед запятыми пробел
                    Separator.SentenceSeparators.Contains(nextElement.Chars))// ||  //перед запятой или точкой пробел

                    //Separator.OperationPunctuationSeparator.Contains(nextElement.Chars))
                    //Separator.OperationPunctuationSeparator.Contains(Items[_index].Chars) ||
                    //Separator.CloseSeparator.Contains(nextElement.Chars) ||
                    continue;

                //if (Separator.CloseSeparator.Contains(Items[_index].Chars))
                //{
                //    break;
                //}

                // чтобы в конце после ковычек не было пробела
                if (Separator.OpenSeparator.Contains(Items[_index].Chars)
                    || Separator.RepeatSeparator.Contains(Items[_index].Chars))
                { GlueWords(_index, strBuilder); }

                // добавляем в конце (пробелы между словами)
                if (!Separator.CloseSeparator.Contains(nextElement.Chars))
                { strBuilder.Append(" "); }
            }
        }



        /// <summary>
        /// Проверяем вопросительное ли предложение
        /// </summary>
        public bool IsInterrogative
            => Items.Last().Chars == "?"
            || Items.Last().Chars == "?!"
            || Items.Last().Chars == "!?";


        /// <summary>
        /// Получаем слова без посторений
        /// </summary>
        /// <param name="length">длинна заданного слова</param>
        /// <returns>массив слов</returns>
        public IEnumerable<IWord> GetWordsWithoutRepetition(int length)
        {
            return Items.Where(x => x is Word).Cast<Word>().Where(x => x.Length == length);
        }



        //Возвращает элемент последовательности, удовлетворяющий указанному условию.
        //https://msdn.microsoft.com/ru-ru/library/bb534960(v=vs.110).aspx    ????
        public ISentence RemoveWordsBy(Func<IWord, bool> predicate)
        {
            return new Sentence(Items.Where(x => !(x is IWord && predicate((IWord)x))));
        }


        
    }
}
