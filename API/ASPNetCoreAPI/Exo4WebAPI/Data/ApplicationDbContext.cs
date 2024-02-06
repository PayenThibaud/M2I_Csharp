using Exo4WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Exo4WebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            int lastIndex = 0;
            var contacts = new List<Contact>()
            {
                new Contact()
                {
                    Id = ++lastIndex,
                    Nom = "Benjamin",
                    Prenom = "Fontaine",
                    DateDeNaissance = new DateTime(1997, 10, 19),
                    Sexe1 = Sexe.Mâle,
                    Avatar = "http://localhost:port/Avatars/force.png"
                },
                new Contact()
                {
                    Id = ++lastIndex,
                    Nom = "Alice",
                    Prenom = "Dupont",
                    DateDeNaissance = new DateTime(1990, 12, 05),
                    Sexe1 = Sexe.Femelle,
                    Avatar = "http://localhost:port/Avatars/avatar2.png"
                },
                new Contact()
                {
                    Id = ++lastIndex,
                    Nom = "Louis",
                    Prenom = "Lefevre",
                    DateDeNaissance = new DateTime(1985, 06, 15),
                    Sexe1 = Sexe.Mâle,
                    Avatar = "http://localhost:port/Avatars/avatar3.png"
                },
                new Contact()
                {
                    Id = ++lastIndex,
                    Nom = "Sophie",
                    Prenom = "Martin",
                    DateDeNaissance = new DateTime(2000, 03, 23),
                    Sexe1 = Sexe.Femelle,
                    Avatar = "http://localhost:port/Avatars/avatar4.png"
                },
                new Contact()
                {
                    Id = ++lastIndex,
                    Nom = "Luc",
                    Prenom = "Robert",
                    DateDeNaissance = new DateTime(1980, 08, 10),
                    Sexe1 = Sexe.Mâle,
                    Avatar = "http://localhost:port/Avatars/avatar5.png"
                },
            };

            modelBuilder.Entity<Contact>().HasData(contacts);
        }
    }
}
