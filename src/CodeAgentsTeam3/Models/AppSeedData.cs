using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Data.Entity;
using System.IO;

namespace CodeAgentsTeam3.Models
{
    public static class AppSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            var context = serviceProvider.GetService<ApplicationDbContext>();
            if (context.Database == null)
            {
                throw new Exception("DB is null");
            }
            if (context.FindTalents.Any())
            {
                return;   // DB already seeded
            }

            context.FindTalents.AddRange(
                new FindTalent() { FirstName = "Akhil", LastName = "Kankanala", Profession = "Actor", Experience = 3, Rating = 3, Image = "~/lib/bootstrap/dist/images/Akhil_Fil.jpg" },
                new FindTalent() { FirstName = "Erica", LastName = "Sudheer", Profession = "Actress", Experience = 5, Rating = 4, Image = "~/lib/bootstrap/dist/images/Erica_Fil.jpg" },
                new FindTalent() { FirstName = "Kalyan", LastName = "Akula", Profession = "Cameraman", Experience = 4, Rating = 3, Image = "~/lib/bootstrap/dist/images/Kalyan_Fil.jpg" },
                new FindTalent() { FirstName = "Karthik", LastName = "Kuppilli", Profession = "Actor, Producer", Experience = 3, Rating = 5, Image = "~/lib/bootstrap/dist/images/Melwin_Fil.jpg" }
             );
            context.SaveChanges();
        }
    }
}
