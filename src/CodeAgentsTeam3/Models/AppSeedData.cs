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
                new FindTalent() { FirstName = "Anvesh", LastName = "Kankanala", Profession = "Actor", Experience = 3, Rating = 3 },
                new FindTalent() { FirstName = "Mohan", LastName = "Sudheer", Profession = "Director", Experience = 5, Rating = 4 },
                new FindTalent() { FirstName = "Ritwik", LastName = "Akula", Profession = "Cameraman", Experience = 4, Rating = 3 },
                new FindTalent() { FirstName = "Karthik", LastName = "Kuppilli", Profession = "Producer", Experience = 3, Rating = 5 }
             );
            context.SaveChanges();
        }
    }
}
