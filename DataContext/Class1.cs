using Microsoft.EntityFrameworkCore;
using Repository.Entity;
using Repository.Interfaces;
using System.Diagnostics.Metrics;

namespace DataContext
{
    public class DataContext1 : DbContext, IContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Measure> Measures { get; set; }
        //public DbSet<Follower> Followers { get; set; }
        //public DbSet<Comment> Comments { get; set; }
        public async Task save()
        {
            await SaveChangesAsync();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=recipies;Trusted_Connection=True;");
        }

    }
}