using System.Collections.Generic;

namespace NewYearPresent.Gift
{
    public interface IGift
    {
        IEnumerable<GiftElement> Elements { get; }
        void Add( GiftElement giftElements);
        int GiftWeight();



        //void Add(string v1, int v2, int v3, int v4, CandyElement.TypeCandyElement chocolateCandy);
    }
}
