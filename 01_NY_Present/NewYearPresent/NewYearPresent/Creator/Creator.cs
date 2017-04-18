using static NewYearPresent.CandyElement;
using static NewYearPresent.ChocoElement;
using static NewYearPresent.Elements.WaffleElement;

namespace NewYearPresent.Creator
{
    public abstract class Creator
    {
        public abstract GiftElement BuildCandy(
            string elementName,
            int elementWeith,
            int elementSugar,
            int elementCalories,
            TypeCandyElement type);

        public abstract GiftElement BuildChoco(
            string elementName,
            int elementWeith,
            int elementSugar,
            int elementCalories,
            TypeChocoElement type);

        public abstract GiftElement BuildWaffle(
            string elementName,
            int elementWeith,
            int elementSugar,
            int elementCalories,
            TypeWaffleElement type);
    }
}
