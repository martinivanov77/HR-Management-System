﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employeeList;

        public MockEmployeeRepository()
        {
            employeeList = new List<Employee>()
            {
                new Employee()
                {
                Id = 1,
                FirstName = "Ivan",
                LastName = "Ivanov",
                StartingDate = new DateTime(2016, 10, 10),
                Salary = 4025.5m,
                VacationDays = 25,
                ExperienceLevel = ExperienceLevel.Senior,
                Offices = new List<Office>() { new Office { Country = "USA", City = "New York", Street = "Wall Street", StreetNumber = 10, IsHQ = true } }
                },
                new Employee()
                {
                    Id = 2,
                    FirstName = "John",
                    LastName = "Doe",
                    StartingDate = new DateTime(2019, 10, 10),
                    Salary = 3025.5m,
                    VacationDays = 25,
                    ExperienceLevel = ExperienceLevel.Junior,
                    Offices = new List<Office>() { new Office { Country = "USA", City = "New York", Street = "Wall Street", StreetNumber = 10, IsHQ = true } }
                },
                 new Employee()
                {
                    Id = 3,
                    FirstName = "Mike",
                    LastName = "Jones",
                    StartingDate = new DateTime(2020,02,02),
                    Salary = 1000.5m,
                    VacationDays = 25,
                    ExperienceLevel = ExperienceLevel.Intern,
                    Offices = new List<Office>() { new Office { Country = "USA", City = "New York", Street = "Wall Street", StreetNumber = 10, IsHQ = true } }
                },

            };

        }

        public Employee Add(Employee employee)
        {
            employee.Id = this.employeeList.Max(e => e.Id) + 1;
            this.employeeList.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return this.employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return this.employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}