using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAgentsTeam3.Models
{
    public class Producer
    {
        [ScaffoldColumn(false)]
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Display(Name = "Date Of Birth")]
        [Range(typeof(DateTime), "1920,1,1", "2016,12,31")]
        public DateTime DateOfBirth { get; set; }

        public string Place { get; set; }

        public string Language { get; set; }

        
        [Display(Name = "Experience as a Producer")]
        [RegularExpression(@"^[a-zA-Z”-‘\s]{1,500}$")]
        public object Experience;

        [Display(Name = "Expected Remuneration")]
        public string Remuneration { get; set; }

        public string Achievements { get; set; }

        [Display(Name = "Education Qualifications")]
        public string EducationQualification { get; set; }

    }
}
