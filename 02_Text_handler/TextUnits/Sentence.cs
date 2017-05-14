using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

                if (Separator.SentenceSeparators.Contains(Items[_index].Chars) ||   // , . ? ! !? ?! ...
                    Separator.InnerSeparator.Contains(nextElement.Chars) ||         // , ; :
                    Separator.SentenceSeparators.Contains(nextElement.Chars))       // , . ? ! !? ?! ...
                    continue;

                // чтобы в конце после ковычек не было пробела
                if (Separator.OpenSeparator.Contains(Items[_index].Chars) // все открытые скобки
                    || Separator.RepeatSeparator.Contains(Items[_index].Chars)) //закрытая " скобка
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
        /// Получаем слова без повторений заданной длинны
        /// </summary>
        /// <param name="length">длинна заданного слова</param>
        /// <returns>массив слов</returns>
        public IEnumerable<IWord> GetWordsWithoutRepetition(int length)
        {
            return Items.Where(x => x is Word).Cast<Word>().Where(x => x.Length == length);
        }


        //Возвращает элемент последовательности, удовлетворяющий указанному условию.
        //https://msdn.microsoft.com/ru-ru/library/bb534960(v=vs.110).aspx    
        //https://habrahabr.ru/post/256821/
        //http://stackoverflow.com/questions/11143602/possible-ways-to-use-func-t-bool-while-using-a-linq-repository

        public ISentence RemoveWordsBy(Func<IWord, bool> predicate)
        {
            return new Sentence(Items.Where(x => !(x is IWord && predicate((IWord)x))));
        }

        //
        public IEnumerable<ISentenceItem> ReplaceWord(Func<IWord, bool> predicate, IList<ISentenceItem> items)
        {
            var newSentence = new List<ISentenceItem>();
            foreach (var item in Items)
            {
                //сравнение принадлежит ли наш объект этому типу
                if (item is IWord && predicate(item as IWord))//приведение без исключения (если что null)
                {
                    newSentence.AddRange(items);
                    continue;
                }
                newSentence.Add(item);
            }
            return newSentence;
        }
    }
}
