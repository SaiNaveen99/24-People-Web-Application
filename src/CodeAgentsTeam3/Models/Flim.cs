using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeAgentsTeam3.Models
{
    public class Flim
    {
        public int FlimID { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public string Title { get; set; }
        public string Role { get; set; }

        //public virtual Profile Profile { get; set; }
    }
}
