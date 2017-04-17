using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearPresent
{
    public class CandyElement : GiftElement
    {
        public CandyElement(string elementName, int elementWeith, int elementSugar, int elementCalories) : base(elementName, elementWeith, elementSugar, elementCalories)
        {
        }

        public override void TypeGiftElement()
        {
            throw new NotImplementedException();
        }
    }
}
