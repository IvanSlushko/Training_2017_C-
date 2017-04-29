using System.Collections.Generic;

namespace NewYearPresent.Gift
{
    public interface IGift
    {
        IEnumerable<GiftElement> Elements { get; }
        void Add(GiftElement giftElements);
        int GiftWeight();
        int GiftSumCalories();
        void SortByWeight();
        void SortByCalorie();
        void SortByName();
        IEnumerable<GiftElement> FindBySugar(int min, int max);
    }
}
