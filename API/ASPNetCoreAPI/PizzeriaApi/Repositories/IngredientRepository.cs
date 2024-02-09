using Microsoft.EntityFrameworkCore;
using PizzeriaApi.Data;
using PizzeriaApi.Models;
using System.Linq.Expressions;

namespace PizzeriaApi.Repositories
{
    public class IngredientRepository : IRepository<Ingredient>
    {
        private readonly AppDbContext _db;

        public IngredientRepository(AppDbContext db)
        {
            _db = db;
        }

        // CREATE
        public async Task<Ingredient?> Add(Ingredient ingredient)
        {
            var addEntry = await _db.Ingredients.AddAsync(ingredient);
            await _db.SaveChangesAsync();

            if (addEntry.Entity.Id > 0)
                return addEntry.Entity;

            return null;
        }

        // READ
        public async Task<Ingredient?> Get(int id)
        {
            return await _db.Ingredients.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Ingredient?> Get(Expression<Func<Ingredient, bool>> predicate)
        {
            return await _db.Ingredients.FirstOrDefaultAsync(predicate);
        }

        public async Task<IEnumerable<Ingredient>> GetAll()
        {
            return await _db.Ingredients.ToListAsync();
        }

        public async Task<IEnumerable<Ingredient>> GetAll(Expression<Func<Ingredient, bool>> predicate)
        {
            return await _db.Ingredients.Where(predicate).ToListAsync();
        }

        // UPDATE
        public async Task<Ingredient?> Update(Ingredient ingredient)
        {
            var ingredientFromDb = await _db.Ingredients.FirstOrDefaultAsync(i => i.Id == ingredient.Id);

            if (ingredientFromDb == null)
                return null;

            // Update properties
            if (ingredientFromDb.Name != ingredient.Name)
                ingredientFromDb.Name = ingredient.Name;
            if (ingredientFromDb.Description != ingredient.Description)
                ingredientFromDb.Description = ingredient.Description;

            await _db.SaveChangesAsync();

            return ingredientFromDb;
        }

        // DELETE
        public async Task<bool> Delete(int id)
        {
            var ingredientFromDb = await Get(id);

            if (ingredientFromDb == null)
                return false;

            _db.Ingredients.Remove(ingredientFromDb);

            return await _db.SaveChangesAsync() > 0;
        }
    }
}
