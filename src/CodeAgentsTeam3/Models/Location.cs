using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAgentsTeam3.Models
{
    public class Location
    {
        [ScaffoldColumn(false)]
        [Key]
        public int LocationID { get; set; }

        public string Country { get; set; }

        public string Place { get; set; }

        public string State { get; set; }

        [Display(Name = "State Abbrevaition")]
        public string StateAbbreviation { get; set; }

        public string County { get; set; }

        [RegularExpression(@"^\d{5}(?:[-\s]\d{4})?$", ErrorMessage = "Please enter a valid US ZIP code")]
        public string ZipCode { get; set; }

        [RegularExpression("[+-]?\\d*\\.?\\d+", ErrorMessage = "Inavlid Input")]
        public double Latitude { get; set; }

        public double Longitude { get; set; }


        // Navigation Property.
        public virtual ICollection<Director> Director { get; set; }
    }
}
