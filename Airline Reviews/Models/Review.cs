using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Airline_Reviews.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; } // Key value for Review 
        public string Title { get; set; } // Review title

        [ForeignKey("Category")] 
        public int CategoryID { get; set; } // Foreign key for Category model
        public virtual Category Category { get; set; }
        
        public int FlightNum { get; set; } // Flight number
        public string Origin { get; set; } // Origin airport
        public string Dest { get; set; } // Destination airport
        public string Cabin { get; set; } // Cabin/class of travel
        public DateTime ReviewDate { get; set; } // Review date/time
        public int Stars { get; set; } // Number of stars
        public string ReviewBody { get; set; } // Body/text of review
    }
}
