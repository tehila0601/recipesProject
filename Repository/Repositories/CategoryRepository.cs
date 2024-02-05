﻿using Microsoft.EntityFrameworkCore;
using Repository.Entity;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private readonly IContext _context;
        public CategoryRepository(IContext context)
        {
            _context = context;
        }
        public async Task AddItemAsync(Category item)
        {
            await _context.Categories.AddAsync(item);
            await _context.save();
        }

        public async Task DeleteAsync(int id)
        {
            _context.Categories.Remove(await GetAsyncById(id));
            await _context.save();
        }

        public async Task<List<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetAsyncById(int id)
        {
            return await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(int id, Category item)
        {
            var category = await GetAsyncById(id);
            if (category != null)
            {
                if (category.Name != null) category.Name = item.Name;
                await _context.save();
            }
            else
            {
                throw new Exception("this category doesn't exist");
            }
        }
    }
}
