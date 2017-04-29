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
        public void SortByWeight()
        {
            var tempSortEl = elements.OrderBy(x => x.weight).ToList();
            elements.Clear();
            foreach (var element in tempSortEl)
            {
                elements.Add(element);
            }

        }
        public void SortByCalorie()
        {
            var tempSortEl = elements.OrderBy(x => x.calories).ToList();
            elements.Clear();
            foreach (var element in tempSortEl)
            {
                elements.Add(element);
            }
        }

        public void SortByName()
        {
            var tempSortEl = elements.OrderBy(x => x.name ).ToList();
            elements.Clear();
            foreach (var element in tempSortEl)
            {
                elements.Add(element);
            }
        }

        public IEnumerable<GiftElement> FindBySugar(int min, int max)
        {
            if (elements != null)
            {
                var tempFind = elements.Where(x => (x.sugar >= min) && (x.sugar <= max)).ToList();
                elements.Clear();
                foreach (var element in tempFind)
                {
                    elements.Add(element);
                }
                return elements;
            }
            else
            {
                throw new InvalidOperationException("null!!!!!!");
            }
        }
    }
}
