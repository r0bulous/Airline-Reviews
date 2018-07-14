using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Airline_Reviews.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Display(Name = "Airline")]
        public string AirlineName { get; set; } // Name of air carrier
        public virtual ICollection<Review> Reviews { get; set; } // ICollection for Reviews
        public string HomeCountry { get; set; } // Home country of air carrier
    }
}