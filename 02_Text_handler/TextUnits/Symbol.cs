using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextHandler.TextUnits
{
    public struct Symbol

    {
        public string Chars { get; set; }

        public Symbol(string chars)
        {
            Chars = chars;
        }

        public Symbol(char source)
        {
            Chars = String.Format("{0}", source);
            //this.chars = String.Format("{0}", source);
        }

        //public bool IsUppercase
        //{
        //   // get { return chars != null && chars.Length >= 1 && char.IsLetter(chars[0]) && char.IsUpper(chars[0]); }
        //}

        //public bool IsLower
        //{
        //   // get { return chars != null && chars.Length >= 1 && char.IsLetter(chars[0]) && char.IsLower(chars[0]); }
        //}
    }
}
