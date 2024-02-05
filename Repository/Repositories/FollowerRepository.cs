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
    public class FollowerRepository /*: IRepository<Follower>*/
    {
        //private readonly IContext _context;
        //public FollowerRepository(IContext context)
        //{
        //    _context = context;
        //}
        //public async Task AddItemAsync(Follower item)
        //{
        //    await _context.Followers.AddAsync(item);
        //    await _context.save();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    _context.Followers.Remove(await GetAsyncById(id));
        //    await _context.save();
        //}

        //public async Task<List<Follower>> GetAllAsync()
        //{
        //    return await _context.Followers.ToListAsync();
        //}

        //public async Task<Follower> GetAsyncById(int id)
        //{
        //    return await _context.Followers.FirstOrDefaultAsync(x => x.Id == id);
        //}

        //public async Task UpdateAsync(int id, Follower item)
        //{
        //    var follower = await GetAsyncById(id);
        //    if (follower.follower != null) follower.follower = item.follower;
        //    if (follower.followerAfterId != 0) follower.followerAfterId = item.followerAfterId;
        //     follower.isUser = item.isUser;


        //    await _context.save();
        //}
    }
}
