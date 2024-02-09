using Microsoft.EntityFrameworkCore;
using PizzeriaApi.Data;
using PizzeriaApi.Models;
using PizzeriaApi.Repositories;
using System.Linq.Expressions;

namespace pizzaApiDTO.Repositories
{
    public class PizzaRepository : IRepository<Pizza>
    {
        private readonly AppDbContext _db;

        public PizzaRepository(AppDbContext db)
        {
            _db = db;
        }

        // CREATE
        public async Task<Pizza?> Add(Pizza pizza)
        {
            var addEntry = await _db.Pizzas.AddAsync(pizza); // retourne un EntityEntry<pizza> qui enveloppe le nouveau pizza créé
            await _db.SaveChangesAsync();

            if (addEntry.Entity.Id > 0) // si l'entité est bien ajoutée l'id est > 0
                return addEntry.Entity;

            return null; // erreur lors de l'ajout
        }


        // READ
        public async Task<Pizza?> Get(int id)
        {
            //return _db.pizzas.Find(id); // ne fonctionne que sur un DbSet<> (EFCore)
            return await _db.Pizzas.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Pizza?> Get(Expression<Func<Pizza, bool>> predicate)
        {
            return await _db.Pizzas.FirstOrDefaultAsync(predicate);
        }

        public async Task<IEnumerable<Pizza>> GetAll()
        {
            return _db.Pizzas;
            // DbSet<> implémente l'interface IEnumerable
            // en ne faisant pas le .ToList() tout de suite, on repousse l'exécution de la requête LINQ
            // cela est plus otpimisé/pratique

            //return await _db.pizzas.ToListAsync();
        }

        public async Task<IEnumerable<Pizza>> GetAll(Expression<Func<Pizza, bool>> predicate)
        {
            return _db.Pizzas.Where(predicate);
            //return await _db.pizzas.Where(predicate).ToListAsync();
        }


        // UPDATE




        public async Task<Pizza?> Update(Pizza pizza)
        {
            var pizzaFromDb = await _db.Pizzas.FirstOrDefaultAsync(p => p.Id == pizza.Id);

            if (pizzaFromDb == null)
                return null; // Pizza non trouvée dans la base de données

            // Mettre à jour les propriétés de la pizza
            if (pizzaFromDb.Nom != pizza.Nom)
            pizzaFromDb.Nom = pizza.Nom;
            if (pizzaFromDb.Description != pizza.Description)
            pizzaFromDb.Description = pizza.Description;
            if (pizzaFromDb.Prix != pizza.Prix)
            pizzaFromDb.Prix = pizza.Prix;
            if (pizzaFromDb.Image != pizza.Image)
            pizzaFromDb.Image = pizza.Image;
            if (pizzaFromDb.isVegetarienne != pizza.isVegetarienne)
            pizzaFromDb.isVegetarienne = pizza.isVegetarienne;
            if (pizzaFromDb.isPiquante != pizza.isPiquante)
            pizzaFromDb.isPiquante = pizza.isPiquante;

            // Enregistrer les modifications dans la base de données
            await _db.SaveChangesAsync();

            return pizzaFromDb;
        }



        // DELETE
        public async Task<bool> Delete(int id)
        {
            var pizzaFromDb = await Get(id); // entitée récupérée donc TRAQUEE par l'ORM (EFCore)

            if (pizzaFromDb == null)
                return false; // erreur lors de la suppression => pizza non trouvé

            _db.Pizzas.Remove(pizzaFromDb);

            return await _db.SaveChangesAsync() > 0;
        }
    }
}
