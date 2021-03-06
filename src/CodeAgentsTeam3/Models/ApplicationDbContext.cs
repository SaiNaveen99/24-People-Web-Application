﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using CodeAgentsTeam3.Models;

namespace CodeAgentsTeam3.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<Actress> Actress { get; set; }
        public DbSet<Director> Director { get; set; }
        public DbSet<Producer> Producer { get; set; }
        public DbSet<Cameraman> Cameraman { get; set; }
        public DbSet<Actor> Actor { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Profile> profiles { get; set; }
        public DbSet<Flim> flims { get; set; }
        public DbSet<Photo> photos { get; set; }
        public DbSet<Education> educations { get; set; }
        public DbSet<FindTalent> FindTalents { get; set; }

    }
}
