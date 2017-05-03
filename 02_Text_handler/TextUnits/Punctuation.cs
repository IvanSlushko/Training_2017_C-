using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextHandler.Interfaces;

namespace TextHandler.TextUnits
{
    public class Punctuation : IPunctuation
    {

        public Punctuation(string chars)
        { Symbols = new Symbol(chars); }

        public string Chars    //   => Symbols.Chars  
        { get { return Symbols.Chars; } }

        public Symbol Symbols { get; }

    }
}
