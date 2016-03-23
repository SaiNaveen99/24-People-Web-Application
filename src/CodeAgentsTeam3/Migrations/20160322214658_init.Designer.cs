using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using CodeAgentsTeam3.Models;

namespace CodeAgentsTeam3.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160322214658_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeAgentsTeam3.Models.Actor", b =>
                {
                    b.Property<int>("ActorID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Achievements");

                    b.Property<string>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<int>("Height");

                    b.Property<string>("Languages");

                    b.Property<string>("LastName");

                    b.Property<int>("LocationID");

                    b.Property<int>("NumberOfMovies");

                    b.Property<string>("Qualification");

                    b.Property<int>("Rating");

                    b.Property<double>("Remuneration");

                    b.Property<double>("Weight");

                    b.Property<int>("YearsOfExperience");

                    b.HasKey("ActorID");
                });

            modelBuilder.Entity("CodeAgentsTeam3.Models.Actress", b =>
                {
                    b.Property<int>("ActressID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Achievements");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("EducationQualification");

                    b.Property<string>("FirstdName");

                    b.Property<string>("Language");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Place");

                    b.Property<string>("Remuneration");

                    b.HasKey("ActressID");
                });

            modelBuilder.Entity("CodeAgentsTeam3.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasAnnotation("Relational:Name", "EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .HasAnnotation("Relational:Name", "UserNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetUsers");
                });

            modelBuilder.Entity("CodeAgentsTeam3.Models.Cameraman", b =>
                {
                    b.Property<int>("CameramanID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Achievements");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("EducationQualification");

                    b.Property<string>("FirstdName")
                        .IsRequired();

                    b.Property<string>("Language");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Place");

                    b.Property<string>("Remuneration");

                    b.HasKey("CameramanID");
                });

            modelBuilder.Entity("CodeAgentsTeam3.Models.Director", b =>
                {
                    b.Property<int>("DirectorID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Description");

                    b.Property<string>("Ethinicity");

                    b.Property<string>("Experience");

                    b.Property<string>("Eyes");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("Hair");

                    b.Property<string>("Height");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("NativeLanguage");

                    b.Property<string>("Remuneration");

                    b.Property<string>("Sex");

                    b.Property<string>("Weight");

                    b.Property<string>("mail");

                    b.HasKey("DirectorID");
                });

            modelBuilder.Entity("CodeAgentsTeam3.Models.Education_Director", b =>
                {
                    b.Property<int>("DirectorID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Degree")
                        .IsRequired();

                    b.Property<int?>("DirectorsDirectorID");

                    b.Property<string>("Year");

                    b.HasKey("DirectorID");
                });

            modelBuilder.Entity("CodeAgentsTeam3.Models.Film_Director", b =>
                {
                    b.Property<int>("DirectorID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DirectorsDirectorID");

                    b.Property<string>("Role");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("DirectorID");
                });

            modelBuilder.Entity("CodeAgentsTeam3.Models.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country");

                    b.Property<string>("County");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("Place");

                    b.Property<string>("State");

                    b.Property<string>("StateAbbreviation");

                    b.Property<string>("ZipCode");

                    b.HasKey("LocationID");
                });

            modelBuilder.Entity("CodeAgentsTeam3.Models.Photos_Director", b =>
                {
                    b.Property<int>("DirectorID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DirectorsDirectorID");

                    b.Property<int>("PhotoNo");

                    b.Property<string>("URL");

                    b.HasKey("DirectorID");
                });

            modelBuilder.Entity("CodeAgentsTeam3.Models.Producer", b =>
                {
                    b.Property<int>("ProducerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Achievements");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("EducationQualification");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("Language");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Place");

                    b.Property<string>("Remuneration");

                    b.HasKey("ProducerID");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasAnnotation("Relational:Name", "RoleNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasAnnotation("Relational:TableName", "AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasAnnotation("Relational:TableName", "AspNetUserRoles");
                });

            modelBuilder.Entity("CodeAgentsTeam3.Models.Actor", b =>
                {
                    b.HasOne("CodeAgentsTeam3.Models.Location")
                        .WithMany()
                        .HasForeignKey("LocationID");
                });

            modelBuilder.Entity("CodeAgentsTeam3.Models.Education_Director", b =>
                {
                    b.HasOne("CodeAgentsTeam3.Models.Director")
                        .WithMany()
                        .HasForeignKey("DirectorsDirectorID");
                });

            modelBuilder.Entity("CodeAgentsTeam3.Models.Film_Director", b =>
                {
                    b.HasOne("CodeAgentsTeam3.Models.Director")
                        .WithMany()
                        .HasForeignKey("DirectorsDirectorID");
                });

            modelBuilder.Entity("CodeAgentsTeam3.Models.Photos_Director", b =>
                {
                    b.HasOne("CodeAgentsTeam3.Models.Director")
                        .WithMany()
                        .HasForeignKey("DirectorsDirectorID");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CodeAgentsTeam3.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CodeAgentsTeam3.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("CodeAgentsTeam3.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
        }
    }
}
