using System;
using System.Collections.Generic;
using System.Linq;

namespace NewYearPresent.Gift
{
    public class Gift : IGift
    {
        private ICollection<GiftElement> elements;

        public Gift()
        {
            elements = new List<GiftElement>();
        }

        public IEnumerable<GiftElement> Elements
        {
            get
            {
                return elements;
            }
        }

        public void Add(GiftElement giftElements)
        {
            elements.Add(giftElements);
        }

        public int GiftWeight()
        {
            return elements.Sum(x => x.weight);
        }
        public int GiftSumCalories()
        {
            return elements.Sum(x => x.calories);
        }
    }
}
