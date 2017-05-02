namespace NewYearPresent
{
    public abstract class GiftElement
    {
        public string name { get; private set; }
        public int weight { get; private set; }
        public int sugar { get; private set; }
        public int calories { get; private set; }

       // public abstract void TypeGiftElement();

        public GiftElement(string elementName, int elementWeight, int elementSugar, int elementCalories)
        {
            name = elementName;
            weight = elementWeight;
            sugar = elementSugar;
            calories = elementCalories;
        }
    }
}
