using NewYearPresent.Enum;
using System;

namespace NewYearPresent.Creators
{
    public class WaffleElementCreator : Creator
    {
        public override GiftElement Build(
            string elementName,
            int elementWeigth,
            int elementSugar,
            int elementCalories,
            TypeWaffleElement type)
        {
            return new WaffleElement(
            elementName,
            elementWeigth,
            elementSugar,
            elementCalories,
            type);
        }

        public override GiftElement Build(string elementName, int elementWeigth, int elementSugar, int elementCalories, TypeCandyElement type)
        {
            throw new NotImplementedException();
        }

        public override GiftElement Build(string elementName, int elementWeigth, int elementSugar, int elementCalories, TypeChocoElement type)
        {
            throw new NotImplementedException();
        }


    }
}
