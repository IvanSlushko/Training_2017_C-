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

        //int result1 = Sum(integers, x => x > 5);
        //int result2 = Sum(integers, x => x % 2 == 0);
        //var q2 = orders.Join(
        //        users,
        //        order => order.UserId,
        //        user => user.Id,
        //        (order, user) => new { OrderId = order.Id, UserName = user.Name, OrderSum = order.Sum }
        //            ).ToConsole(x => String.Format("{0} {1}", x.OrderId, x.UserName));

        //        Sum with Selector

        //This example sums lengths of all strings in the list.

        //var stringList = new List<string> { "88888888", "22", "666666", "333" };

        //        // these two lines do the same
        //        int lengthSum = stringList.Select(x => x.Length).Sum();  // lengthSum: 19
        //        int lengthSum = stringList.Sum(x => x.Length);           // lengthSum: 19
        public int GiftWeith()
        {
            return elements.Sum(x => x.weith);
        }
    }
}
