using NewYearPresent.Enum;
using System;
using System.Collections;
using System.Collections.Generic;
using static NewYearPresent.CandyElement;
using static NewYearPresent.ChocoElement;
using static NewYearPresent.WaffleElement;

namespace NewYearPresent.Creators
{
    public abstract class Creator
    {

        IDictionary<string, GiftElement> diction = new Dictionary<string, GiftElement>();

       // diction.

    //    _dictionary.Add(  "ChocolateCandy", TypeCandyElement.ChocolateCandy);
    //_dictionary.Add(  "DropCandy", TypeCandyElement.DropCandy);
    //        _dictionary.Add(  "Sweetmeat", TypeCandyElement.Sweetmeat);
           
            
           
        //IDictionary<string, CreateObjMethod> _dictionary = new Dictionary<string, CreateObjMethod>();
        //IDictionary<string, Enumer> _d1
        //{
        //    { ChocolateCandy, 
        //            , DropCandy
        //            , Sweetmeat },

        //}

        //protected Enumer GetEnumByString(string param)
        //{
            
        //}






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
