using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextHandler.Interfaces;
using TextHandler.TextUnits;

namespace TextHandler.Parsers
{
    public abstract class Parser
    {
        public abstract Text Parse(StreamReader fileReader);
        public abstract ISentence ParseSentence(string sentence);
    }
}
