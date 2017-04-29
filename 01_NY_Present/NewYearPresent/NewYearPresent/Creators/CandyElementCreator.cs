using NewYearPresent.Enums;
using System;

namespace NewYearPresent.Creators
{
    public class CandyElementCreator : Creator
    {
        public override GiftElement Build(
            string elementName, 
            int elementWeigth, 
            int elementSugar, 
            int elementCalories,
            TypeCandyElement type)
        {
            return new CandyElement (
                elementName, 
                elementWeigth, 
                elementSugar, 
                elementCalories, 
                type);
        }

        public override GiftElement Build(string elementName, int elementWeigth, int elementSugar, int elementCalories, TypeChocoElement type)
        {
            throw new NotImplementedException();
        }

        public override GiftElement Build(string elementName, int elementWeigth, int elementSugar, int elementCalories, TypeWaffleElement type)
        {
            throw new NotImplementedException();
        }
    }
}
