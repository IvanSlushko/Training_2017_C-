using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextHandler.Interfaces
{
    public interface ISentence
    {
        IList<ISentenceItem> Items { get; }
        string SentenceToString();
        bool IsInterrogative { get; }
        IEnumerable<IWord> GetWordsWithoutRepetition(int length);




    }
}
