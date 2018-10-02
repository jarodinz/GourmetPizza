using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GourmetPizza.Models
{
    public class Customer
    {
        public int ID { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 2)]
        [RegularExpression(@"[a-zA-Z-""'\]*$")]
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
        [Display(Name ="Date Of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string DateOfBirth { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public string PostCode { get; set; }
    }
}
