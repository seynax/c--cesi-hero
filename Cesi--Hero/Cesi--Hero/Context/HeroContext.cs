using Cesi__Hero.Model;
using Microsoft.EntityFrameworkCore;

namespace Cesi__Hero.Context
{
    public class HeroContext : DbContext
    {
        public HeroContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=L35301222-10\\MSSQLSERVER01;Integrated Security=True;Encrypt=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Hero> Heroes { get; set; }
    }
}
