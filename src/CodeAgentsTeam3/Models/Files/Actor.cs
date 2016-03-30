using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAgentsTeam3.Models
{
    public class Actor
    {
        [ScaffoldColumn(false)]
        [Key]
        public int ActorID { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Of Birth")]
        //[Range(typeof(DateTime), "1920,1,1", "2016,12,31")]
        public string DateOfBirth { get; set; }

        [ScaffoldColumn(false)]
        public int LocationID { get; set; }


        // Navigation Property
        public virtual Location Location { get; set; }

        //public string Place { get; set; }

        public string Languages { get; set; }

        [Display(Name = "Number of Movies")]
        public int NumberOfMovies { get; set; }

        [Display(Name = "Experience")]
        public int YearsOfExperience { get; set; }

        [Display(Name = "Expected Remuneration per movie ")]
        public double Remuneration { get; set; }

        public string Achievements { get; set; }

        public string Qualification { get; set; }

        public int Height { get; set; }

        public double Weight { get; set; }

        public int Rating { get; set; }
    }
}

