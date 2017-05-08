using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextHandler.Parsers
{
    public static class Separator
    {
        //private string[] sentenceSeparators = new string[] { "?", "!", ".", "...", "?!" };
        //private string[] wordSeparators = new string[] { " ", " - " };
        //public static string[] RepeatPunctuationSeparator { get; } = { "\"", "'" };
        //public static string[] Digits { get; } = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        //public static string[] WordSeparators = new string[] { " ", " - " };
        //public static string[] OperationPunctuationSeparator { get; } = { "*", "/", "+", "=", "==", "!=", ">=", "=<" };

        public static string[] SentenceSeparators { get; } = { "!", ".", "?", "...", "?!", "!?" };
        //public IEnumerable<string> SentenceSeparators()
        //{
        //    return sentenceSeparators.AsEnumerable();
        //}

        public static string[] AllSeparators { get; } = {
            ",", ".", "!", "?", "—", "-", "\"", "'", "(", ")",
            "<", ">", ":", ";", "[", "]", "{", "}", "‒", "–", "—",
            "―", "„", "“", "«", "»", "‘", "’", "...", "?!", "!?",
            "*", "/", "=", "==", "!=", ">=", "=<", "+"};
        public static string[] InnerSeparator { get; } = { ",", ";", ":" };
        public static string[] OpenSeparator { get; } = { "<", "(", "[", "{", "„", "«", "‘" };
        public static string[] CloseSeparator { get; } = { ")", ">", "]", "}", "“", "»", "’" };
        public static string[] RepeatSeparator { get; } = { "\"", "'"};
        public static string[] RuVowelsSeparator { get; } = { "а", "А", "у", "У", "о", "О", "ы", "Ы", "и", "И", "э", "Э", "я", "Я", "ю", "Ю", "ё", "Ё", "е","Е" };

    }
}
