using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAgentsTeam3.Models
{
    public class Education_Director
    {
        [Required]
        [RegularExpression("^[a-zA-Z0-9]*$",ErrorMessage ="Should contain only String")]
        public string Degree { get; set; }

        [RegularExpression("(?< ![-.])\b[0 - 9] +\b(?!.[0 - 9])", ErrorMessage = "Should contain only Integer")]
        public string Year { get; set; }


        [Key]
        public int DirectorID { get; set; }
        // Navigation Property
        public virtual Director Directors { get; set; }

    }
}
