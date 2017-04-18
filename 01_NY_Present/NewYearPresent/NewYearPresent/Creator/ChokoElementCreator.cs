using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewYearPresent.Elements;

namespace NewYearPresent.Creator
{
    public class ChokoElementCreator : Creator

    {
        public override GiftElement BuildCandy(string elementName, int elementWeith, int elementSugar, int elementCalories, CandyElement.TypeCandyElement type)
        {
            throw new NotImplementedException();
        }

        public override GiftElement BuildChoco(string elementName, int elementWeith, int elementSugar, int elementCalories, ChocoElement.TypeChocoElement type)
        {
            throw new NotImplementedException();
        }

        public override GiftElement BuildWaffle(string elementName, int elementWeith, int elementSugar, int elementCalories, WaffleElement.TypeWaffleElement type)
        {
            throw new NotImplementedException();
        }
    }
}
