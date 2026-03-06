using LINQ.Day3.Configurations;
//using LINQ.Day3.Configuration_Classes;
using LINQ.Day3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Day3.DbContect
{
    internal class BookstoreDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=.;Database=BookstoreDB;Trusted_Connection=True;");

        }

        public DbSet<Book> Book1 { get; set; }
        public DbSet<Author> Authors1 { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // This will apply all configurations in the assembly
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookConfiguration).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
