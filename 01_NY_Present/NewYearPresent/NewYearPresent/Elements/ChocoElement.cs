using System;

namespace NewYearPresent
{
    public class ChocoElement : GiftElement
    {
        public enum TypeChocoElement { MilkChocolate, PorousChocolate, DarkChocolate };
        public TypeChocoElement type;

        public ChocoElement(string elementName, int elementWeith, int elementSugar, 
            int elementCalories, TypeChocoElement type) : 
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
