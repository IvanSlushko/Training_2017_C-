using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewYearPresent.Elements;
using NewYearPresent;

namespace NewYearPresent.Creators
{
    public class ChokoElementCreator : Creator

    {
        public override GiftElement Build(
            string elementName,
            int elementWeigth,
            int elementSugar,
            int elementCalories,
            ChocoElement.TypeChocoElement type)
        {
            return new ChocoElement(
            elementName,
            elementWeigth,
            elementSugar,
            elementCalories,
            type);
        }

        public override GiftElement Build(string elementName, int elementWeigth, int elementSugar, int elementCalories, CandyElement.TypeCandyElement type)
        {
            throw new NotImplementedException();
        }

        public override GiftElement Build(string elementName, int elementWeigth, int elementSugar, int elementCalories, WaffleElement.TypeWaffleElement type)
        {
            throw new NotImplementedException();
        }
    }
}
