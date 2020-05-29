using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
        }
        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(3000);
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "T",
                LastName = "T",
                Email = "tt@gmail.com",
                DateOfBirth = new DateTime(1999, 9, 9),
                Gender = Gender.Female,
                DepartmentId = 2,
                PhotoPath = "images/trumpapporvd.jpg"
            };

            Employee e2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "J",
                LastName = "J",
                Email = "jj@gmail.com",
                DateOfBirth = new DateTime(1956, 8, 7),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/trumpapporvd.jpg"
            };

            Employee e3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "K",
                LastName = "K",
                Email = "kk@gmail.com",
                DateOfBirth = new DateTime(1987, 6, 5),
                Gender = Gender.Other,
                DepartmentId = 3,
                PhotoPath = "images/trumpapporvd.jpg"
            };

            Employee e4 = new Employee
            {
                EmployeeId = 4,
                FirstName = "L",
                LastName = "L",
                Email = "ll@gmail.com",
                DateOfBirth = new DateTime(1979, 3, 2),
                Gender = Gender.Female,
                DepartmentId = 1,
                PhotoPath = "images/trumpapporvd.jpg"
            };
            Employees = new List<Employee> { e1, e2, e3, e4 };
        }
    
    }
}
