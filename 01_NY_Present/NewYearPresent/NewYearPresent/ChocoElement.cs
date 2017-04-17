using System;

namespace NewYearPresent
{
    public class ChocoElement : GiftElement
    {
        public TypeGiftElement type;

        public ChocoElement(string elementName, int elementWeith, int elementSugar, 
            int elementCaloriepes, TypeGiftElement type) : base(elementName, elementWeith, elementSugar, elementCalories)
        {
            this.type = type;
        }

        public override void TypeGiftElement()
        {
            throw new NotImplementedException();
        }
    }
}
