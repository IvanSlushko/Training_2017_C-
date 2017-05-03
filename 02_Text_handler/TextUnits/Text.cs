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
        {
            Sentences = new List<ISentence>();
        }

        public List<ISentence> Sentences { get; set; }










    }
}
