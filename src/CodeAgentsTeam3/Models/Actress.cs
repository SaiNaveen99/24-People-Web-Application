using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAgentsTeam3.Models
{
    public class Actress
    {
        [ScaffoldColumn(false)]
        public int ActressID { get; set; }
        [Required]

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        public string FirstdName { get; set; }

        
        [Display(Name = "Date Of Birth")]
        [Range(typeof(DateTime.), "1920,1,1", "2016,12,31")]
        public DateTime DateOfBirth { get; set; }
        
        public string Place { get; set; }

        public string Language { get; set; }

        //Work experience within 500 characters
        [Display(Name = "Experience as a Actress in Brief")]
        [RegularExpression(@"^[a-zA-Z”-‘\s]{1,500}$")]
        public object Experience;

        [Display(Name = "Expected Remuneration per movie ")]
        public string Remuneration { get; set; }

        public string Achievements { get; set; }

        public string EducationQualification { get; set; }
     }
  }
