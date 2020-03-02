using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Office> Offices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee()
                {
                    Id = 1,
                    FirstName = "Petar",
                    LastName = "Petrov",
                    StartingDate = new DateTime(2020, 02, 02),
                    Salary = 550.5m,
                    ExperienceLevel = ExperienceLevel.Junior,
                    VacationDays = 25,
                });

            modelBuilder.Entity<Office>().HasData(
                new Office
                {
                    Id = 1,
                    City = "NYC",
                    Country = "USA",
                    Street = "Wall st",
                    StreetNumber = 1,
                    EmployeeId = 1,
                    IsHQ = true
                }
                );
        }
    }

}




