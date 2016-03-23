using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace CodeAgentsTeam3.Models
{
    public class Film_Director
    {
        [Required]
        public string Title { get; set; }


        public string Role { get; set; }

        [Key]
        public int DirectorID { get; set; }
        // Navigation Property
        public virtual Director Directors { get; set; }
    }
}