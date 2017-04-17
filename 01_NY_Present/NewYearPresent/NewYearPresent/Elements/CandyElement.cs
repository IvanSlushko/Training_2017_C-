using System;

namespace NewYearPresent
{

    public class CandyElement : GiftElement
    {
        public enum TypeCandyElement { ChocolateCandy, DropCandy , Sweetmeat };
        public TypeCandyElement type;
        

        public CandyElement(string elementName, int elementWeith, int elementSugar,
            int elementCalories, TypeCandyElement type) : 
            base(elementName, elementWeith, elementSugar, elementCalories)
        {
            this.type = type;
        }

        public override void TypeGiftElement()
        {
            throw new NotImplementedException();
        }
    }
}