using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewYearPresent.Elements;

namespace NewYearPresent.Creator
{
    class CandyElementCreator : Creator
    {

        //class ConcreteBuilder : Builder
        //{
        //    Product product = new Product();
        //    public override void BuildPartA()
        //    {
        //        product.Add("Part A");
        //    }
        //    public override void BuildPartB()
        //    {
        //        product.Add("Part B");
        //    }
        //    public override void BuildPartC()
        //    {
        //        product.Add("Part C");
        //    }
        //    public override Product GetResult()
        //    {
        //        return product;
        //    }
        //}
        public override GiftElement BuildCandy(
            string elementName, 
            int elementWeith, 
            int elementSugar, 
            int elementCalories,
            CandyElement.TypeCandyElement type)
        {
            return new CandyElement (
                elementName, 
                elementWeith, 
                elementSugar, 
                elementCalories, 
                type);
        }

        public override GiftElement BuildChoco(string elementName, int elementWeith, int elementSugar, int elementCalories, ChocoElement.TypeChocoElement type)
        {
            throw new NotImplementedException();
        }

        public override GiftElement BuildWaffle(string elementName, int elementWeith, int elementSugar, int elementCalories, WaffleElement.TypeWaffleElement type)
        {
            throw new NotImplementedException();
        }
    }
}
