using NewYearPresent.Enum;
using System;

namespace NewYearPresent
{
    public class ChocoElement : GiftElement
    {
        public TypeChocoElement type;

        public ChocoElement(
            string elementName, 
            int elementWeight, 
            int elementSugar, 
            int elementCalories, 
            TypeChocoElement type) : 
            base(elementName, elementWeight, elementSugar, elementCalories)
        {
            this.type = type;
        }

        public override void TypeGiftElement()
        {
            throw new NotImplementedException();
        }
    }
}
