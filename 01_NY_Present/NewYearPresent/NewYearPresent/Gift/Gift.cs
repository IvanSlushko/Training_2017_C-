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

        public void Add (GiftElement giftElements)
        {
            elements.Add(giftElements);
        }

        //int result1 = Sum(integers, x => x > 5);
        //int result2 = Sum(integers, x => x % 2 == 0);

        public int GiftWeith()
        {
            return elements.Sum.ToConsole();
        }
    }
}
