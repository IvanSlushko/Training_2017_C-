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
            CandyElement.TypeCandyElement type)
        {
            return new CandyElement (
                elementName, 
                elementWeigth, 
                elementSugar, 
                elementCalories, 
                type);
        }

        public override GiftElement Build(string elementName, int elementWeigth, int elementSugar, int elementCalories, ChocoElement.TypeChocoElement type)
        {
            throw new NotImplementedException();
        }

        public override GiftElement Build(string elementName, int elementWeigth, int elementSugar, int elementCalories, WaffleElement.TypeWaffleElement type)
        {
            throw new NotImplementedException();
        }
    }
}
