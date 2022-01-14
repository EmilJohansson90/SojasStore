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
        public DbSet<Email> Emails { get; set; }



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
            modelbuilder.ApplyConfiguration(new EmployeeEntityConfig());


            modelbuilder.Entity<Email>()
                .HasKey(e => new { e.Emails, e.EmployeeSsn })
                ;

            modelbuilder.Entity<Ingredients>()
                .HasKey(i => new { i.Ingredient, i.ProductProductId })
                ;

            modelbuilder.Entity<Product>()
                .Property(p => p.BestBefore)
                .HasColumnType("Date");


            // ----- SEEDS ------

            var e1 = new Employee() { EmployeeId = 1001, Name = "Erik", PhoneNumber = "123-456", Ssn = 1001 };
            var e2 = new Employee() { EmployeeId = 1002, Name = "Johanna", PhoneNumber = "456-789", Ssn = 2001 };
            var e3 = new Employee() { EmployeeId = 1003, Name = "Eva", PhoneNumber = "789-123", Ssn = 1850 };

            modelbuilder.Entity<Employee>()
                .HasData(
                    e1,
                    e2,
                    e3
                );

            var mail1 = new Email() { Emails = "erik@gmail.com", EmployeeSsn = e1.Ssn };
            var mail2 = new Email() { Emails = "youngNfab@live.se", EmployeeSsn = e2.Ssn };
            var mail3 = new Email() { Emails = "jjonsson@gmail.com", EmployeeSsn = e2.Ssn };
            var mail4 = new Email() { Emails = "evalarsson@ghotmail.com", EmployeeSsn = e3.Ssn };
            var mail5 = new Email() { Emails = "eva@gmail.com", EmployeeSsn = e3.Ssn };
            modelbuilder.Entity<Email>()
                .HasData(
                    mail1,
                    mail2,
                    mail3,
                    mail4,
                    mail5
                );

            var d1 = new Department() { DepartmentId = 10, InChargeSsn = e1.Ssn, Name = "Mejeri" };
            var d2 = new Department() { DepartmentId = 11, InChargeSsn = e2.Ssn, Name = "Kött" };
            var d3 = new Department() { DepartmentId = 12, InChargeSsn = e2.Ssn, Name = "Bröd" };
            var d4 = new Department() { DepartmentId = 13, InChargeSsn = e3.Ssn, Name = "Skafferi" };
            var d5 = new Department() { DepartmentId = 14, InChargeSsn = e1.Ssn, Name = "Grönsaker" };
            var d6 = new Department() { DepartmentId = 15, InChargeSsn = e1.Ssn, Name = "Grönsaker" };

            modelbuilder.Entity<Department>()
                .HasData(
                    d1,
                    d2,
                    d3,
                    d4,
                    d5,
                    d6
                );

            var p1 = new Product() { ProductId = 10001, Name = "Mjölk", Amount = 2, BestBefore = DateTime.ParseExact("2022-01-30", "yyyy-MM-dd", null), BarCode = 123456, Price = 13.50, CheckedDate = DateTime.ParseExact("2021-12-30 12:30", "yyyy-MM-dd HH:mm", null), CheckedBySsn = e2.Ssn };
            var p2 = new Product() { ProductId = 10002, Name = "Kaffe", Amount = 8, BestBefore = DateTime.ParseExact("2022-09-25", "yyyy-MM-dd", null), BarCode = 222555, Price = 25.99, CheckedDate = DateTime.ParseExact("2021-12-25 11:45", "yyyy-MM-dd HH:mm", null), CheckedBySsn = e1.Ssn };
            var p3 = new Product() { ProductId = 10003, Name = "Grädde", Amount = 12, BestBefore = DateTime.ParseExact("2022-01-25", "yyyy-MM-dd", null), BarCode = 558874, Price = 54.20, CheckedDate = DateTime.ParseExact("2022-01-10 23:45", "yyyy-MM-dd HH:mm", null), CheckedBySsn = e1.Ssn };
            var p4 = new Product() { ProductId = 10004, Name = "Ost", Amount = 1, BestBefore = DateTime.ParseExact("2022-03-15", "yyyy-MM-dd", null), BarCode = 654321, Price = 108.50, CheckedDate = DateTime.ParseExact("2022-01-02 16:59", "yyyy-MM-dd HH:mm", null), CheckedBySsn = e1.Ssn };
            var p5 = new Product() { ProductId = 10005, Name = "Fisk", Amount = 90, BestBefore = DateTime.ParseExact("2022-01-21", "yyyy-MM-dd", null), BarCode = 258369, Price = 81.90, CheckedDate = DateTime.ParseExact("2022-01-02 08:25", "yyyy-MM-dd HH:mm", null), CheckedBySsn = e3.Ssn };
            var p6 = new Product() { ProductId = 10006, Name = "Bröd", Amount = 15, BestBefore = DateTime.ParseExact("2022-01-26", "yyyy-MM-dd", null), BarCode = 147258, Price = 25.90, CheckedDate = DateTime.ParseExact("2022-01-06 11:35", "yyyy-MM-dd HH:mm", null), CheckedBySsn = e3.Ssn };

            modelbuilder.Entity<Product>()
                .HasData(
                    p1,
                    p2,
                    p3,
                    p4,
                    p5,
                    p6
                );

            //---Koder för att förhindra Identity-felkoder-- -
            foreach (var relationship in modelbuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}




