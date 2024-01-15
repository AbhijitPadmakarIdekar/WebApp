using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WebApp.Domain.Entities;

namespace WebApp.DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeId = 1, FirstName = "Aslam", LastName = "Shaikh", Salary = 100.9F, Department = "X" },
                new Employee { EmployeeId = 2, FirstName = "Abhijit", LastName = "Idekar", Salary = 300.9F, Department = "B" },
                new Employee { EmployeeId = 3, FirstName = "Maksud", LastName = "Aditya", Salary = 200.9F, Department = "P" });

            modelBuilder.Entity<User>().HasData(
                new User { UserID = 1, UserName = "Abhijit", Password = "12345", EmailAddress = "AbhjitIdekar@gmail.com" },
                new User { UserID = 2, UserName = "Ramesh", Password = "123xyz", EmailAddress = "RameshMali@gmail.com" },
                new User { UserID = 3, UserName = "Akshay", Password = "Jadhav1", EmailAddress = "AkshayJadhav@gmail.com" });
        }
    }
}
