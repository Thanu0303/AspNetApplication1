using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetApplication1.Models
{
    public class Customer
    {
        public string CustomerId { get; set; }            // prop tab tab

        public string CompanyName { get; set; }
        public string ContactName { get; set; }

        public string Country { get; set; }

        public string City { get; set; }
    }
}