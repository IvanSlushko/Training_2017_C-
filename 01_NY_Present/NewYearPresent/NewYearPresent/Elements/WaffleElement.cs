using System;

namespace NewYearPresent.Elements
{
    class WaffleElement : GiftElement
    {
        public enum TypeWaffleElement { };
        public TypeWaffleElement type;

        public WaffleElement(string elementName, int elementWeith, int elementSugar,
            int elementCalories, TypeWaffleElement type) :
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
