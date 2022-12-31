using Microsoft.EntityFrameworkCore;
using StoreApplicationWithEfcore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApplicationWithEfcore.Models.Contexts
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext()
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=ICT-NASIRI; Initial Catalog=StoreEf; Integrated Security=True ;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Warranty>().HasKey(p => p.ProductId);
            modelBuilder.Entity<Product>().HasOne(p => p.Warranty).WithOne(p => p.Product).HasForeignKey<Warranty>(p => p.ProductId);

            //modelBuilder.Entity<Product>().HasKey(p => p.Name);
            modelBuilder.Entity<Customer>().Property(e => e.Name)
            .HasColumnName("Fullname")
            .HasColumnType("nvarchar(50)");
        }
    }
}
