using System;

namespace NewYearPresent
{
    public class CandyElement : GiftElement
    {
        public TypeGiftElement type;

        public CandyElement(string elementName, int elementWeith, int elementSugar, 
            int elementCalories, TypeGiftElement type) : base(elementName, elementWeith, elementSugar, elementCalories)
        {
            this.type = type;
        }

        public override void TypeGiftElement()
        {
            throw new NotImplementedException();
        }
    }
}
