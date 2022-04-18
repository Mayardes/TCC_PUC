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
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<User>().Property(x => x.Name).HasColumnType("varchar").HasMaxLength(100);
            modelBuilder.Entity<User>().Property(x => x.Password).HasMaxLength(100);
            
            modelBuilder.Entity<Role>().HasKey(x => x.Id);
            modelBuilder.Entity<Role>().Property(x => x.Description).HasColumnType("varchar").HasMaxLength(100);

            modelBuilder.Entity<Company>().HasKey(x => x.Id);
            modelBuilder.Entity<Company>().Property(x => x.CompanyName).HasColumnType("varchar").HasMaxLength(200);
            modelBuilder.Entity<Company>().Property(x => x.Address).HasColumnType("varchar").HasMaxLength(250);
            modelBuilder.Entity<Company>().Property(x => x.MunicipalRegistration).HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Company>().Property(x => x.StateRegistration).HasColumnType("varchar").HasMaxLength(50);


            modelBuilder.Entity<Employee>().HasKey(x => x.Id);
            modelBuilder.Entity<Employee>().Property(x => x.Name).HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Employee>().Property(x => x.Position).HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Employee>().Property(x => x.Department).HasColumnType("varchar").HasMaxLength(80);



        }
    }
}
