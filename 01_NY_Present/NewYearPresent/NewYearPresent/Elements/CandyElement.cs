using NewYearPresent.Enum;
using System;

namespace NewYearPresent
{
    public class CandyElement : GiftElement
    {
        public TypeCandyElement type;

        public CandyElement(
            string elementName,
            int elementWeigth,
            int elementSugar,
            int elementCalories,
            TypeCandyElement type) :
            base(elementName, elementWeigth, elementSugar, elementCalories)
        {
            this.type = type;
        }

        public override void TypeGiftElement()
        {
            throw new NotImplementedException();
        }
    }
}