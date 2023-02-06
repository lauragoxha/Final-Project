using Microsoft.EntityFrameworkCore;
using StudentApp.Data.Models;

namespace StudentApp.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("DataSource=Main.db");

        public DbSet<Product> Products { get; set; }
    }
}
