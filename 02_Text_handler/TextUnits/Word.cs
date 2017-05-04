using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextHandler.Interfaces;

namespace TextHandler.TextUnits
{
    public class Word : IWord
    {

        public Word(string chars)
        {
            if (chars != null)
            { Symbols = chars.Select(x => new Symbol(x)).ToArray(); }
            else { Symbols = null; }
        }


        public Symbol[] Symbols { get; }


        public Symbol this[int index]
        { get { return Symbols[index]; } }

        //public int Length { get; }

        public int Length
        { get { return (Symbols != null) ? Symbols.Length : 0; } }



    }
}
