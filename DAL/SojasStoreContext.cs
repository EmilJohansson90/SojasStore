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



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=localhost\SQLEXPRESS;Database=SojasStore;Integrated security=true;";
            optionsBuilder
                   .UseSqlServer(connectionString)
                   .LogTo(Console.WriteLine, LogLevel.Information)
                   .EnableSensitiveDataLogging()
                   ;
        }
    }
}
