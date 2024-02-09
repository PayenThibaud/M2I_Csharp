using Microsoft.EntityFrameworkCore;
using PizzeriaApi.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PizzeriaApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
#nullable disable
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<PizzaIngredient> PizzaIngredients { get; set; }
#nullable enable

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<PizzaIngredient>().HasKey(pi => new { pi.PizzaId, pi.IngredientId });

            var adminRoot = new Utilisateur()
            {
                Id = 1,
                Prenom = "Root",
                Nom = "ROOT",
                Email = "Titi@gmail.com",
                Numero = "0606060606",
                Adresse = "rue de la rue, Rue",
                IsAdmin = true
            };
            modelBuilder.Entity<Utilisateur>().HasData(adminRoot);
        }
    }
}
