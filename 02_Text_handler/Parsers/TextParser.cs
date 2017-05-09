using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
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

                while ((line = fileReader.ReadLine()) != null)//Выполняет чтение строки символов из 
                                                              //текущего потока и возвращает данные в виде строки.(Переопределяет TextReader.ReadLine().)
                {
                    if (Regex.Replace(line.Trim(), @"\s+", @" ") != "")  // 1 пробел или более тримим
                    {
                        line = buffer + line;

                        var sentences = _lineToSentenceRegex.Split(line) //Разделяет входную строку в массив подстрок в позициях, определенных шаблоном регулярного выражения.
                                .Select(x => Regex.Replace(x.Trim(), @"\s+", @" "))// заменяет все строки, соответствующие указанному регулярному выражению, указанной строкой замены
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
                fileReader.Dispose();//Освобождает все ресурсы, используемые объектом TextReader
            }
            return textResult;
        }


        public override ISentence ParseSentence(string sentence)
        {
            var result = new Sentence();

            // итем становится ....))
            // condition ? first_expression : second_expression;
            //если condition true - first expression
            //если false - second expression
            //https://msdn.microsoft.com/ru-ru/library/system.text.regularexpressions.match(v=vs.110).aspx

            Func<string, ISentenceItem> toISentenceItem =
                item => (!Separator.AllSeparators.Contains(item))
                       ? (ISentenceItem)new Word(item)
                       : new Punctuation(item);

            //Представляет результаты из отдельного совпадения регулярного выражения.
            foreach (Match match in _sentenceToWordsRegex.Matches(sentence))
            {
                for (var i = 1; i < match.Groups.Count; i++)
                {
                    if (match.Groups[i].Value.Trim() != "")
                    { result.Items.Add(toISentenceItem(match.Groups[i].Value.Trim())); }
                }
            }
            return result;
        }

    }
}
