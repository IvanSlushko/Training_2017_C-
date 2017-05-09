using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextHandler.Interfaces;
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

        public ISentence this[int index] => Sentences[index];

        public IEnumerable<ISentence> SortByAscending() => Sentences.OrderBy(x => x.Items.Count);

        public IEnumerable<IWord> GetWordsGivenLength(int length)
        {
            var result = new List<IWord>();
            foreach (var sentence in Sentences.Where(sentence => sentence.IsInterrogative))
            { result.AddRange(sentence.GetWordsWithoutRepetition(length)); }
            return result.GroupBy(x => x.Chars.ToLower()).Select(x => x.First()).ToList();
        }


    }
}
