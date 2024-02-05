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
    public class UserRepository : IRepository<User>
    {
        private readonly IContext _context;
        public UserRepository(IContext context)
        {
            _context = context;
        }
        public async Task AddItemAsync(User item)
        {
            await _context.Users.AddAsync(item);
            await _context.save();
        }

        public async Task DeleteAsync(int id)
        {
            _context.Users.Remove(await GetAsyncById(id));
            await _context.save();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetAsyncById(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(int id, User item)
        {
            var user = await GetAsyncById(id);
            if (user.Name != null) user.Name = item.Name;
            if (user.Email != null) user.Email = item.Email;
            if (user.Password != null) user.Password = item.Password;
            if (user.Level != 0) user.Level = item.Level;

            await _context.save();
        }
    }
}
