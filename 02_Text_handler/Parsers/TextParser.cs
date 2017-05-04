using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        //https://msdn.microsoft.com/ru-ru/library/system.text.regularexpressions.regexoptions(v=vs.110).aspx

        //string input = @"07/14/2007";
        //string pattern = @"(-)|(/)";

        //    foreach (string result in Regex.Split(input, pattern))
        //    {
        //        Console.WriteLine("'{0}'", result);
        //    }


        // Compiled: при установке этого значения регулярное выражение компилируется в сборку, 
        // что обеспечивает более быстрое выполнение
        //!!!!!!! https://msdn.microsoft.com/ru-ru/library/az24scfc(v=vs.110).aspx

        //[класс символов]
        //(?<= часть выражения) утверждение положительного просмотра
        // \ - привязки
        // | Соответствует любому элементу, разделенному вертикальной чертой(|).



        private readonly Regex _lineToSentenceRegex = new Regex(
                   @"(?<=[\.*!\?])\s+(?=[А-Я]|[A-Z])|(?=\W&([А-Я]|[A-Z]))", RegexOptions.Compiled);

        private readonly Regex _sentenceToWordsRegex = new Regex(
                @"(\W*)(\w+[\-|`]\w+)(\!\=|\>\=|\=\<|\/|\=\=|\?\!|\!\?|\.{3}|\W)|(\W*)(\w+|\d+)(\!\=|\>\=|\=\<|\/|\=\=|\?\!|\!\?|\.{3}|\W)|(.*)",
                RegexOptions.Compiled);





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
