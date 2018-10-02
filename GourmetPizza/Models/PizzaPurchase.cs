using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GourmetPizza.Models
{
    public class PizzaPurchase
    {
        [Display(Name = "Pizza Name")]
        public string PizzaName { get; set; }
        [Display(Name = "Number of Pizzas")]
        public int PizzaCount { get; set; }
        [RegularExpression(@"^([0-9]{16})$")]
        public int CreditCard { get; set; }
    }
}
