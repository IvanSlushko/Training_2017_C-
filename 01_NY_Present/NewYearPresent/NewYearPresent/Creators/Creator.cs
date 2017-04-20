using static NewYearPresent.CandyElement;
using static NewYearPresent.ChocoElement;
using static NewYearPresent.Elements.WaffleElement;

namespace NewYearPresent.Creators
{
    public abstract class Creator
    {
        public abstract GiftElement Build(
            string elementName,
            int elementWeigth,
            int elementSugar,
            int elementCalories,
            TypeCandyElement type);

        public abstract GiftElement Build(
            string elementName,
            int elementWeigth,
            int elementSugar,
            int elementCalories,
            TypeChocoElement type);

        public abstract GiftElement Build(
            string elementName,
            int elementWeigth,
            int elementSugar,
            int elementCalories,
            TypeWaffleElement type);
    }
}
