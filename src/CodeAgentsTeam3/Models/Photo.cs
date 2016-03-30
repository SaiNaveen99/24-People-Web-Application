using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeAgentsTeam3.Models
{
    public class Photo
    {
        public int PhotoID { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public string PhotoURL { get; set; }
    }
}
