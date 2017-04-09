using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Interfaces
{
    public interface IMedia
    {
        ICollection<IMediaItem> Items { get; }
        string Name { get; }
        string Url { get; }
    }
}
