using Cesi__Hero.Model;
using Microsoft.EntityFrameworkCore;

namespace Cesi__Hero.Context
{
    public class HeroContext : DbContext
    {
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Power> Powers { get; set; }
        public DbSet<School> Schools { get; set; }

        public HeroContext()
        {
        }

        // Database Config
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSqlLocalDB;Integrated Security=True;Encrypt=False");
        }

        // Fluent API Config
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relation One-to-Many between Hero and School
            modelBuilder.Entity<Hero>()
                .HasOne(h => h.School)
                .WithMany(s => s.Heroes)
                .HasForeignKey(h => h.SchoolId);

            // Relation Many-to-Many between Hero and Power
            modelBuilder.Entity<Hero>()
                .HasMany(h => h.Powers)
                .WithMany(p => p.Heroes)
                .UsingEntity(j => j.ToTable("HeroPower"));

            base.OnModelCreating(modelBuilder);
        }
    }
}

