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
        [Required(ErrorMessage="Each pizza must have a title")]
        [RegularExpression(@"^[A-Z][0-9 a-z'-](1,20)$")]

        public string Name { get; set; }
        public double Price { get; set; }
    }
}
