using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SaleStatistics.Models
{
    public class SaleInfo
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        [StringLength(30, ErrorMessage = "Too many chars")]
        public string Manager { get; set; }

        [StringLength(30, ErrorMessage = "Too many chars")]
        public string Client { get; set; }

        [StringLength(50, ErrorMessage = "Too many chars")]
        public string Product { get; set; }

        public double PriceSum { get; set; }

        //аттрибуты валидации!!
        // https://metanit.com/sharp/mvc/7.3.php

    }
}