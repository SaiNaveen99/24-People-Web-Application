using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeAgentsTeam3.Models
{
    public class Education
    {
        public int EducationID { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public string School { get; set; }

        public string Degree { get; set; }

        public int Year { get; set; }
    }
}
