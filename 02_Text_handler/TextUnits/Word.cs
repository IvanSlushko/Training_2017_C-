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
        public Symbol[] Symbols { get; }


        public Word(string chars)
        {
            if (chars != null)
            {
                Symbols = chars.Select(x => new Symbol(x)).ToArray();
            }
            else
            {
                Symbols = null;
            }
        }



        public int Length
        {
            get

            {
                return (Symbols != null) ? Symbols.Length : 0;
            }
        }

        /// <summary>
        /// Добавляет строковое представление указанного объекта Char в данный экземпляр.
        /// </summary>
        public string Chars
        {
            get
            {
                if (string.IsNullOrEmpty(chars))
                {
                    var strBuilder = new StringBuilder();

                    foreach (var symbol in Symbols)
                    {
                        strBuilder.Append(symbol.Chars);
                    }
                    return strBuilder.ToString();
                }

                else
                {
                    return chars;
                }
            }
        }

        private string chars;



        //Проверка первого символа согласный или нет
        public bool IsСonsonant(string[] vowels)
        { return !vowels.Contains(Symbols[0].Chars); }
    }
}
