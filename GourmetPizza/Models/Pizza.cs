using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GourmetPizza.Models
{
    public class Pizza
    {
        public int ID { get; set; }
        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(@"[a-zA-Z0-9-_ ""'\s-]*$")]
        public string Name { get; set; }
        [Display(Name="Price for Each")]
        [Range(5,20)]
        [DataType(DataType.Currency)]
        public double Price { get; set; }
    }

   
}
