using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextHandler.Parsers
{
    public static class Separator
    {

        public static string[] SentenceSeparators { get; } = {".", "?", "!", "...", "?!", "!?" };
        //public IEnumerable<string> SentenceSeparators()
        //{
        //    return sentenceSeparators.AsEnumerable();
        //}

        const string quote = "\"";

        public static string[] AllSeparators { get; } = {
            ",", ".", "!", "?", "—", "-", "\"", "'", "(", ")",
            "<", ">", ":", ";", "[", "]", "{", "}", "‒", "–", "—",
            "―", "„", "“", "«", "»", "‘", "’", "...", "?!", "!?",
            "*", "/", "=", "==", "!=", ">=", "=<", "+"};
        public static string[] InnerSeparator { get; } = { ",", ";", ":" };
        public static string[] OpenSeparator { get; } = { "<", "(", "[", "{", "„", "«", "‘" };
        public static string[] CloseSeparator { get; } = { ")", ">", "]", "}", "“", "»", "’" };
        public static string[] RepeatSeparator { get; } = { "\"", "'", quote }; //   \" - знак "
        public static string[] RuVowelsSeparator { get; } = {
            "а", "А", "у", "У", "о", "О", "ы", "Ы", "и", "И",
            "э", "Э", "я", "Я", "ю", "Ю", "ё", "Ё", "е", "Е" };
        public static string[] RuConsonantSeparator { get; } = {
            " б", "в", "г", "д"," ж"," з", "й"," к"," л"," м", "н",
            "п", "р", "с", "т", "ф", "х", "ц", "ч"," ш"," щ" };


    }
}
