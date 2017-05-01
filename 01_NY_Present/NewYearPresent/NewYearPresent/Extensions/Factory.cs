using NewYearPresent.Creators;
using NewYearPresent.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearPresent.Extensions
{
    public class Factory
    {

        //IDictionary<string, enum> _dictionary = new Dictionary<string, CreatObjectMethod>();
        //IDictionary<string, Enum> _d1;

        //public Factory(IDictionary<string, CreatObjectMethod> dictionary)
        //{
        //    _dictionary = dictionary;
        //}

        protected Enum GetEnumByString(string param)
        {
            if (param == "ChocolateCandy")
            { return TypeCandyElement.ChocolateCandy; }
            if (param == "DropCandy")
            { return TypeCandyElement.DropCandy; }
            if (param == "Sweetmeat")
            { return TypeCandyElement.Sweetmeat; }
            if (param == "MilkChocolate")
            { return TypeChocoElement.MilkChocolate; }
            if (param == "PorousChocolate")
            { return TypeChocoElement.PorousChocolate; }
            if (param == "DarkChocolate")
            { return TypeChocoElement.DarkChocolate; }
            if (param == "ChocolateWaffle")
            { return TypeWaffleElement.ChocolateWaffle; }
            if (param == "CreamyWafer")
            { return TypeWaffleElement.CreamyWafer; }
            else return null;
        }

        public object CreateInstance(string key, string elementName
            ,int elementWeigth, int elementSugar, int elementCalories)
        {
            return null;
        }


    }
}
