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

        //IDictionary<string, enum> _dictionary = new Dictionary<string, Creator>();
        IDictionary<String, Enum> _d1;



        protected Emun GetEnumByString(string param)
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


    }
}
