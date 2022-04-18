using Microsoft.EntityFrameworkCore;
using TCC.Educacional.Api.Models;

namespace TCC.Educacional.Api.Data
{
    public class EducationalContext : DbContext
    {
        public EducationalContext(DbContextOptions<EducationalContext> options) : base(options)
        {

        }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<User>().Property(x => x.Name).HasColumnType("varchar").HasMaxLength(100);
            modelBuilder.Entity<User>().Property(x => x.Password).HasMaxLength(100);
            
            modelBuilder.Entity<Role>().HasKey(x => x.Id);
            modelBuilder.Entity<Role>().Property(x => x.Description).HasColumnType("varchar").HasMaxLength(100);
        }
    }
}
