﻿using NewYearPresent.Enums;
using System;

namespace NewYearPresent
{
    public class WaffleElement : GiftElement
    {
        public TypeWaffleElement type;

        public WaffleElement(
            string elementName, 
            int elementWeigth, 
            int elementSugar,
            int elementCalories, 
            TypeWaffleElement type) :
            base(elementName, elementWeigth, elementSugar, elementCalories)
        {
            this.type = type;
        }

        //public override void TypeGiftElement()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
