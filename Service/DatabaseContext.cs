using DigitalToolLog.Models;
using Microsoft.EntityFrameworkCore;

namespace DigitalToolLog.Service
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public string DbPath { get; set; }

        public DatabaseContext()
        {
            DbPath = System.IO.Path.Join("C:\\Users\\david\\OneDrive\\Desktop", "DigitalToollog.db");

            Database.EnsureCreated();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            {
                modelBuilder.Entity<Employee>()
                    .HasKey(b => b.Id)
                    .HasName("PrimaryKey");
          
            }
        }
    }
}
