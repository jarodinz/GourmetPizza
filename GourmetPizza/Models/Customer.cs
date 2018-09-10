using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GourmetPizza.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
        public string DateOfBirth { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public string PostCode { get; set; }
    }
}
