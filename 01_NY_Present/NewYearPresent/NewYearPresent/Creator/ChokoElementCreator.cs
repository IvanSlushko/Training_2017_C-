using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewYearPresent.Elements;
using NewYearPresent;

namespace NewYearPresent.Creator
{
    public class ChokoElementCreator : Creator

    {
        public override GiftElement BuildChoco(
            string elementName,
            int elementWeith,
            int elementSugar,
            int elementCalories,
            ChocoElement.TypeChocoElement type)
        {
            return new ChocoElement(
          elementName,
          elementWeith,
          elementSugar,
          elementCalories,
          type);
        }

        public override GiftElement BuildCandy(string elementName, int elementWeith, int elementSugar, int elementCalories, CandyElement.TypeCandyElement type)
        {
            throw new NotImplementedException();
        }

        public override GiftElement BuildWaffle(string elementName, int elementWeith, int elementSugar, int elementCalories, WaffleElement.TypeWaffleElement type)
        {
            throw new NotImplementedException();
        }
    }
}
