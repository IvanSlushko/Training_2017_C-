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


        public List<ISentenceItem> Items { get; }// private set; }





    }
}
