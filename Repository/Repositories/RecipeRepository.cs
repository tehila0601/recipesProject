using Microsoft.EntityFrameworkCore;
using Repository.Entity;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class RecipeRepository :IRepository<Recipe>
    {
        private readonly IContext _context;
        public RecipeRepository(IContext context)
        {
            _context = context;
        }
        public async Task AddItemAsync(Recipe item)
        {
            await _context.Recipes.AddAsync(item);
            await _context.save();
        }

        public async Task DeleteAsync(int id)
        {
            _context.Recipes.Remove(await GetAsyncById(id));
            await _context.save();
        }

        public async Task<List<Recipe>> GetAllAsync()
        {
            return await _context.Recipes.ToListAsync();
        }

        public async Task<Recipe> GetAsyncById(int id)
        {
            return await _context.Recipes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(int id, Recipe item)
        {
            var recipe = await GetAsyncById(id);
            if (recipe.Name != null) recipe.Name = item.Name;
            if (recipe.Description != null) recipe.Description = item.Description;
            if (recipe.Instructions != null) recipe.Instructions = item.Instructions;
            if (recipe.DurationOfPreparation != 0) recipe.DurationOfPreparation = item.DurationOfPreparation;
            if (recipe.LevelOfDifficulty != 0) recipe.LevelOfDifficulty = item.LevelOfDifficulty;
            if (recipe.NumOfPieces != 0) recipe.NumOfPieces = item.NumOfPieces;
            if (recipe.UploadTime != DateTime.MinValue) recipe.UploadTime = item.UploadTime;


            await _context.save();
        }
    }
}
