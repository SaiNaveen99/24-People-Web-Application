using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeAgentsTeam3.Models
{
    public class Profile
    {

        [ScaffoldColumn(false)]
        [Key]
        public int ProfileID { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string FirstName { get; set; }

        public int Age { get; set; }

        public int Gender { get; set; }

        public string Ethinicity { get; set; }

        //public List<Fli>

        [RegularExpression("(?< ![-.])\b[0 - 9] +\b(?!.[0 - 9])", ErrorMessage = "Should contain only Integers.")]
        public string Experience { get; set; }

        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Should contain only Strings.")]
        [Display(Name = "Native Language")]
        public string NativeLanguage { get; set; }


        public string Hair { get; set; }

        public string Eyes { get; set; }

        public string Height { get; set; }

        public string Weight { get; set; }

        [Display(Name = "Expected Remuneration")]
        [RegularExpression("(?< ![-.])\b[0 - 9] +\b(?!.[0 - 9])", ErrorMessage = "Should contain only Integers.")]
        public string Remuneration { get; set; }

        //Work experience within 500 characters
        [Display(Name = "Description about yourself")]
        [RegularExpression(@"^[a-zA-Z”-‘\s]{1,500}$")]
        public string Description { get; set; }

        [Display(Name = "Email -ID")]
        [RegularExpression("\b[A - Z0 - 9._ % +-] +@[A-Z0-9.-]+.[A-Z]{2,}\b)")]
        public string mail { get; set; }
    }
}
