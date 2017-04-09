using System.Collections.Generic;

namespace Mediateka.Interfaces
{
    public interface IMedia
    {
        ICollection<IMediaItem> Items { get; }
        string Name { get; }

    }
}
