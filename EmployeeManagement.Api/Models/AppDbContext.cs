using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(new Department
                { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(new Department
                { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(new Department
                { DepartmentId = 3, DepartmentName = "Payroll" });
            modelBuilder.Entity<Department>().HasData(new Department
                { DepartmentId = 4, DepartmentName = "Admin" });
                
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "T",
                LastName = "T",
                Email = "tt@gmail.com",
                DateOfBirth = new DateTime(1999, 9, 9),
                Gender = Gender.Female,
                DepartmentId = 2,
                PhotoPath = "images/trumpapporvd.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                FirstName = "J",
                LastName = "J",
                Email = "jj@gmail.com",
                DateOfBirth = new DateTime(1956, 8, 7),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/trumpapporvd.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                FirstName = "K",
                LastName = "K",
                Email = "kk@gmail.com",
                DateOfBirth = new DateTime(1987, 6, 5),
                Gender = Gender.Other,
                DepartmentId = 3,
                PhotoPath = "images/trumpapporvd.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                FirstName = "L",
                LastName = "L",
                Email = "ll@gmail.com",
                DateOfBirth = new DateTime(1979, 3, 2),
                Gender = Gender.Female,
                DepartmentId = 1,
                PhotoPath = "images/trumpapporvd.jpg"
            });
        }
    }
}
