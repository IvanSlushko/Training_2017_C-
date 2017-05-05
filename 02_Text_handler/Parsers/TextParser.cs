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
            var textResult = new Text();

            try
            {
                string line;
                string buffer = null;

                while ((line = fileReader.ReadLine()) != null)
                {
                    if (Regex.Replace(line.Trim(), @"\s+", @" ") != "")  // 1 пробел или более
                    {
                        line = buffer + line;

                        var sentences = _lineToSentenceRegex.Split(line)
                                .Select(x => Regex.Replace(x.Trim(), @"\s+", @" "))
                                .ToArray();

                        if (
                            !Separator.SentenceSeparators.Contains(
                                sentences.Last().Last().ToString()))
                        {
                            buffer = sentences.Last();
                            textResult.Sentences.AddRange(
                            sentences.Select(x => x).Where(x => x != sentences.Last()).Select(ParseSentence));
                        }
                        else
                        {
                            textResult.Sentences.AddRange(sentences.Select(ParseSentence));
                            buffer = null;
                        }
                    }
                }
            }
            catch (IOException exception)
            {
                Console.WriteLine(exception.Data.ToString());
                fileReader.Close();
            }
            finally
            {
                fileReader.Close();
                fileReader.Dispose();
            }

            return textResult;
        }


        //public override ISentence ParseSentence(string sentence)
        //{
        //    var result = new Sentence();

        //    Func<string, ISentenceItem> toISentenceItem =
        //        item =>
        //            (!Separator.AllSeparators.Contains(item)
        //            && !Separator.Digits.Contains(item[0].ToString()))
        //                ? (ISentenceItem)new Word(item)
        //                : (Separator.Digits.Contains(item[0].ToString()))
        //                ? (ISentenceItem)new Digit(item)
        //                : new Punctuation(item);

        //    foreach (Match match in _sentenceToWordsRegex.Matches(sentence))
        //    {
        //        for (var i = 1; i < match.Groups.Count; i++)
        //        {
        //            if (match.Groups[i].Value.Trim() != "")
        //            {
        //                result.Items.Add(toISentenceItem(match.Groups[i].Value.Trim()));
        //            }
        //        }
        //    }

        //    return result;
        //}

        public override ISentence ParseSentence(string sentence)
        {
            var result = new Sentence();

            Func<string, ISentenceItem> toISentenceItem = item => (!Separator.AllSeparators.Contains(item) && !Separator.Digits.Contains(item[0].ToString()))
                     ? (ISentenceItem)new Word(item) : (Separator.Digits.Contains(item[0].ToString()))
                     ? (ISentenceItem)new Digit(item) : new Punctuation(item);


            foreach (Match match in _sentenceToWordsRegex.Matches(sentence))
            {
                for (var i = 1; i < match.Groups.Count; i++)
                {
                    if (match.Groups[i].Value.Trim() != "")
                    {
                        result.Items.Add(toISentenceItem(match.Groups[i].Value.Trim()));
                    }
                }
            }
            return result;
        }






    }
}
