using System.Collections.Generic;

namespace NewYearPresent.Gift
{
    public interface IGift
    {
        IEnumerable<GiftElement> Elements { get; }
        void Add( GiftElement giftElements);

        int GiftWeith();



    }
}
