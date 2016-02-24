using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Data.Entity;

namespace CodeAgentsTeam3.Models
{
    public static class AppSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ApplicationDbContext>();
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
                new Actor() { FirstName = "Anves", LastName = "Kolluri", DateOfBirth = "11/09/1992", Languages = "Telugu, English", NumberOfMovies = 3, YearsOfExperience = 4, Remuneration = 200.00, Achievements = "", Qualification = "", Height = 173, Weight = 150, Rating = 4, Location = l1 },
                new Actor() { FirstName = "Melwin", LastName = "Sam", DateOfBirth = "10/02/2001", Languages = "English", NumberOfMovies = 2, YearsOfExperience = 2, Remuneration = 100.00, Achievements = "", Qualification = "", Height = 180, Weight = 160, Rating = 3, Location = l2 }
                );


                context.SaveChanges();
            }



        }
    }
}
