using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextHandler.Interfaces;
using TextHandler.Parsers;
using TextHandler.TextUnits;

namespace TextHandler.TextUnits
{
    public class Text
    {
        public Text()
        { Sentences = new List<ISentence>(); }

        public List<ISentence> Sentences { get; set; }

        //public Text(IEnumerable<ISentence> sentences) : this()
        //{
        //    foreach (var sentence in sentences)
        //    { Sentences.Add(sentence); }
        //}

        //public ISentence this[int index] => Sentences[index];

        public IEnumerable<ISentence> SortByAscending() => Sentences.OrderBy(x => x.Items.Count);

        public IEnumerable<IWord> GetWordsGivenLength(int length)
        {
            var result = new List<IWord>();
            foreach (var sentence in Sentences.Where(sentence => sentence.IsInterrogative))
            { result.AddRange(sentence.GetWordsWithoutRepetition(length)); }
            return result.GroupBy(x => x.Chars.ToLower()).Select(x => x.First()).ToList();
        }

        /// <summary>
        /// Удаляем слова на согласную
        /// </summary>
        /// <param name="length"></param>
        public void DeleteConsonantsWords(int length)
        {
            Sentences = Sentences.Select(
                x => x.RemoveWordsBy(y => y.Length == length
                && y.IsСonsonant(Separator.RuVowelsSeparator)))
                .ToList();
        }

        /// <summary>
        /// Выводим обработанные предложения
        /// </summary>
        /// <returns></returns>
        public string TextOut()
        {
            var strBuilder = new StringBuilder();
            foreach (var sentence in Sentences)
            { strBuilder.Append(sentence.SentenceToString() + "\n"); }
            return strBuilder.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index">номер строки</param>
        /// <param name="length">длинна слова, которое будем менять</param>
        /// <param name="line">строка подмены</param>
        /// <param name="parseSentence">метод парсинга и возврат нового предложения</param>
        public void ReplaceSubstring(int index, int length, string line, Func<string, ISentence> parseSentence)
        {
            Sentences[index] =
                new Sentence(Sentences[index].ReplaceWord((x => x.Length == length), parseSentence(line).Items));
        }
    }
}
