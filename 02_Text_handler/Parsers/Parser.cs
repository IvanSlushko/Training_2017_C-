using System.IO;
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
