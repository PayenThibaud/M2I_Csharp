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
                    Nom = "Fontaine",
                    Prenom = "Benjamin",
                    DateDeNaissance = new DateTime(1997, 10, 19),
                    Sexe1 = "M", // Remplacez par la chaîne correspondante à votre nouveau modèle (par exemple, "M" pour masculin)
                    Avatar = "http://localhost:port/Avatars/force.png"
                },
                new Contact()
                {
                    Id = ++lastIndex,
                    Nom = "Dupont",
                    Prenom = "Alice",
                    DateDeNaissance = new DateTime(1990, 12, 05),
                    Sexe1 = "F", // Remplacez par la chaîne correspondante à votre nouveau modèle (par exemple, "F" pour féminin)
                    Avatar = "http://localhost:port/Avatars/avatar2.png"
                },
                // Ajoutez d'autres contacts selon votre nouveau modèle
            };

            modelBuilder.Entity<Contact>().HasData(contacts);
        }
    }
}

