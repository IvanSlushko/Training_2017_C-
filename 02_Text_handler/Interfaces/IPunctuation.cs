using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextHandler.TextUnits;

namespace TextHandler.Interfaces
{
    public interface IPunctuation : ISentenceItem
    {
        Symbol Symbols { get; }
    }
}
