using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SojasStoreContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Sale> Sales { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=localhost\SQLEXPRESS;Database=SojasStore;Integrated security=true;";
            optionsBuilder
                   .UseSqlServer(connectionString)
                   .LogTo(Console.WriteLine, LogLevel.Information)
                   .EnableSensitiveDataLogging()
                   ;
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            var e1 = new Employee() { EmployeeId = 1001, Name = "Erik", PhoneNumber = "123-456", Ssn= 1001 };
            var e2 = new Employee() { EmployeeId = 1002, Name = "Johanna", PhoneNumber = "456-789", Ssn= 2001 };
            var e3 = new Employee() { EmployeeId = 1003, Name = "Eva", PhoneNumber = "789-123", Ssn= 1850 };

            modelbuilder.Entity<Employee>()
                .HasData(
                    e1,
                    e2,
                    e3
                );

            //var p1 = new Product() { ProductId = 10001, Name = "Mjölk", Amount = 2, BestBefore = DateTime.ParseExact("2022-01-30", "yyyy-MM-dd", null), BarCode = 123456, Price = 13.50 };
            //var p2 = new Product() { ProductId = 10002, Name = "Kaffe", Amount = 8, BestBefore = DateTime.ParseExact("2022-09-25", "yyyy-MM-dd", null), BarCode = 222555, Price = 25.99 };
            //var p3 = new Product() { ProductId = 10003, Name = "Grädde", Amount = 12, BestBefore = DateTime.ParseExact("2022-01-25", "yyyy-MM-dd", null), BarCode = 558874, Price = 54.20 };
            //var p4 = new Product() { ProductId = 10004, Name = "Ost", Amount = 1, BestBefore = DateTime.ParseExact("2022-03-15", "yyyy-MM-dd", null), BarCode = 654321, Price = 108.50 };
            //var p5 = new Product() { ProductId = 10005, Name = "Fisk", Amount = 90, BestBefore = DateTime.ParseExact("2022-01-21", "yyyy-MM-dd", null), BarCode = 258369, Price = 81.90 };
            //var p6 = new Product() { ProductId = 10006, Name = "Bröd", Amount = 15, BestBefore = DateTime.ParseExact("2022-01-26", "yyyy-MM-dd", null), BarCode = 147258, Price = 25.90 };

            //modelbuilder.Entity<Product>()
            //    .HasData(
            //        p1,
            //        p2,
            //        p3,
            //        p4,
            //        p5,
            //        p6
            //    );

            modelbuilder.Entity<Product>()
                .Property(p => p.BestBefore)
                .HasColumnType("Date");
        }
    }
}
