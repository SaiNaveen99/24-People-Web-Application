
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAgentsTeam3.Models
{
    public class Director
    {
        [ScaffoldColumn(false)]
        [Key]
        
        public int DirectorID { get; set; }

        
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        public int Age { get; set; }

        public string Ethinicity { get; set; }
        
        public string Sex { get; set; }

        [RegularExpression("(?< ![-.])\b[0 - 9] +\b(?!.[0 - 9])", ErrorMessage = "Should contain only Integers.")]
        public string Experience { get; set; }

        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage ="Should contain only Strings.")]
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


        public static List<Director> ReadAllFromCSV(string filepath)
        {
            List<Director> lst = File.ReadAllLines(filepath)
                                         .Skip(1)
                                         .Select(v => OneFromCsv(v))
                                         .ToList();
            return lst;
        }


        public static Director OneFromCsv(string csvLine)
        {
            if (csvLine.Length == 0)
            {
                Console.WriteLine("End of File");
                return null;
            }
            else {
                string[] values = csvLine.Split(',');
                Director item = new Director();

                

                Console.WriteLine(values);
                
                item.Age = Convert.ToInt32(values[0]);
                item.Description = Convert.ToString(values[1]);
                item.Ethinicity = Convert.ToString(values[2]);
                item.Experience = Convert.ToString(values[3]);
                item.Eyes = Convert.ToString(values[4]);
                item.FirstName = Convert.ToString(values[5]);
                item.Hair = Convert.ToString(values[6]);
                item.Height = Convert.ToString(values[7]);
                item.LastName = Convert.ToString(values[8]);
                item.NativeLanguage = Convert.ToString(values[9]);
                item.Remuneration = Convert.ToString(values[10]);
                item.Sex = Convert.ToString(values[11]);
                item.Weight = Convert.ToString(values[12]);
                item.mail = Convert.ToString(values[13]);

                return item;

            }
        }


        //public virtual ICollection<Film_Director> Film_Directors { get; set; }
        //public virtual ICollection<Photos_Director> Photos_Directors { get; set; }
        //public virtual ICollection<Education_Director> Education_Directors { get; set; }
       
    }
}
