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
    public class TextParser : Parser
    {
        //// Define a case-insensitive regular expression for repeated words.
        //Regex rxInsensitive = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b",
        //  RegexOptions.Compiled | RegexOptions.IgnoreCase);
        //// Define a case-sensitive regular expression for repeated words.
        //Regex rxSensitive = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b",
        //  RegexOptions.Compiled);


        public override Text Parse(StreamReader fileReader)
        {
            throw new NotImplementedException();
        }

        public override ISentence ParseSentence(string sentence)
        {
            throw new NotImplementedException();
        }
    }






}
