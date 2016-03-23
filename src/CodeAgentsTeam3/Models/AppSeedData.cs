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
        public static void Initialize(IServiceProvider serviceProvider,string appPath )
        {
            string relPath = appPath + "//Models//Files//";
            var context = serviceProvider.GetService<ApplicationDbContext>();

            context.Director.RemoveRange(context.Director);
            context.SaveChanges();
            DirectorFromCSV(relPath, context);
            context.Database.Migrate();
           

            if (!context.Locations.Any())
            {
                var l1 = context.Locations.Add(new Location() { Latitude = 17.4126272, Longitude = 78.268675, Place = "Missouri", Country = "India" }).Entity;
                var l2 = context.Locations.Add(new Location() { Latitude = 36.47558772, Longitude = 78.8797, Place = "Nebraska", Country = "India" }).Entity;
                var l3 = context.Locations.Add(new Location() { Latitude = 34.4126272, Longitude = 78.675858, Place = "Ohio", Country = "India" }).Entity;
                var l4 = context.Locations.Add(new Location() { Latitude = 67.4789576, Longitude = 78.746453, Place = "Hyd", Country = "India" }).Entity;
                var l5 = context.Locations.Add(new Location() { Latitude = 89.67894900, Longitude = 78.267686, Place = "Hyderabad", Country = "India" }).Entity;
                var l6 = context.Locations.Add(new Location() { Latitude = 90.4756782, Longitude = 78.978575, Place = "Hyd", Country = "India" }).Entity;
                var l7 = context.Locations.Add(new Location() { Latitude = 56.890786562, Longitude = 78.256575, Place = "Hyderabad", Country = "India" }).Entity;

                context.Actor.AddRange(
                new Actor() { FirstName = "Kalyan", LastName = "Jenasena", DateOfBirth = "11/09/1979", Languages = "Telugu, English", NumberOfMovies = 16, YearsOfExperience = 14, Remuneration = 2000.00, Achievements = "Filmfare", Qualification = "B.A", Height = 175, Weight = 166, Rating = 5, Location = l1 },
                new Actor() { FirstName = "Akhil", LastName = "Pothi", DateOfBirth = "04/15/2002", Languages = "Hindi, English", NumberOfMovies = 1, YearsOfExperience = 1, Remuneration = 100.00, Achievements = "", Qualification = "B.Tech", Height = 180, Weight = 145, Rating = 2, Location = l2 },
                new Actor() { FirstName = "Brad", LastName = "Pitt", DateOfBirth = "11/21/1973", Languages = "English", NumberOfMovies = 6, YearsOfExperience = 5, Remuneration = 3000.00, Achievements = "Oscar, Golden Globe", Qualification = "", Height = 192, Weight = 180, Rating = 5, Location = l3 },
                new Actor() { FirstName = "Melwin", LastName = "Sam", DateOfBirth = "02/16/2001", Languages = "English", NumberOfMovies = 2, YearsOfExperience = 2, Remuneration = 100.00, Achievements = "", Qualification = "", Height = 180, Weight = 160, Rating = 3, Location = l4 },
                new Actor() { FirstName = "Anvesh", LastName = "Kolluri", DateOfBirth = "09/07/1992", Languages = "Telugu, English", NumberOfMovies = 3, YearsOfExperience = 4, Remuneration = 200.00, Achievements = "", Qualification = "", Height = 173, Weight = 150, Rating = 4, Location = l5 },
                new Actor() { FirstName = "Dulquer", LastName = "Salman", DateOfBirth = "10/02/2000", Languages = "Malyalam", NumberOfMovies = 2, YearsOfExperience = 1, Remuneration = 200.00, Achievements = "Nandi", Qualification = "M.Tech", Height = 180, Weight = 160, Rating = 4, Location = l6 }
                );


                context.SaveChanges();
            }

        }

        private static void DirectorFromCSV(string relPath, ApplicationDbContext context)
        {
            string source = relPath + "Directors.csv";
            if (!File.Exists(source))
            {
                throw new Exception("File does not exists..!!!");
            }

            List<Director> list = Director.ReadAllFromCSV(source);
            context.Director.AddRange(list.ToArray());
            context.SaveChanges();
        }
    }
}
