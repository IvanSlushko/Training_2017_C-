﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SaleStatistics.Models
{
    public class Manager
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Second name can not be empty!")]
        [MaxLength(30, ErrorMessage = "Too many chars")]
        public string SecondName { get; set; }
    }
}