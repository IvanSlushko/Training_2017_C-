using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextHandler.Interfaces;

namespace TextHandler.TextUnits
{
    public class Sentence: ISentence
    {
        public Sentence()
        {
            Items = new List<ISentenceItem>();
        }


        public IList<ISentenceItem> Items { get; }// private set; }


        public Sentence(IEnumerable<ISentenceItem> items) : this()
        {
            foreach (var item in items)
            {
                Items.Add(item);
            }
        }









    }
}
