using Microsoft.EntityFrameworkCore;
using RenoMate.Models;

namespace RenoMate.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; } 
    }
}
