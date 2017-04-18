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


        //class Client
        //{
        //    void Main()
        //    {
        //        Builder builder = new ConcreteBuilder();
        //        Director director = new Director(builder);
        //        director.Construct();
        //        Product product = builder.GetResult();
        //    }
        //}
        //class Director
        //{
        //    Builder builder;
        //    public Director(Builder builder)
        //    {
        //        this.builder = builder;
        //    }
        //    public void Construct()
        //    {
        //        builder.BuildPartA();
        //        builder.BuildPartB();
        //        builder.BuildPartC();
        //    }
        //}

        //abstract class Builder
        //{
        //    public abstract void BuildPartA();
        //    public abstract void BuildPartB();
        //    public abstract void BuildPartC();
        //    public abstract Product GetResult();
        //}

        //class Product
        //{
        //    List<object> parts = new List<object>();
        //    public void Add(string part)
        //    {
        //        parts.Add(part);
        //    }
        //}

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
        public override GiftElement BuildCandy(string elementName, int elementWeith, int elementSugar, int elementCalories, CandyElement.TypeCandyElement type)
        {
            throw new NotImplementedException();
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
