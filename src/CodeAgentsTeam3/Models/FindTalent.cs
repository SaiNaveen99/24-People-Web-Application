using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAgentsTeam3.Models
{
    public class FindTalent
    {
        [ScaffoldColumn(false)]
        [Key]
        public int FindTalentID { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        public string Profession { get; set; }

        public int Experience { get; set; }

        public int Rating { get; set; }

    }
}
