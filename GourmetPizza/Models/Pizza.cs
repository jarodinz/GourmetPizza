﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GourmetPizza.Models
{
    public class Pizza
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

   
}
