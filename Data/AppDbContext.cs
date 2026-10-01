using Combine_API_Recap.Models;
using Microsoft.EntityFrameworkCore;

namespace Combine_API_Recap.Data
{
    public class AppDbContext : DbContext
    {
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Character> Characters {get;set;}
    }
}