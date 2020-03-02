using HRManagement.Models;
using HRManagement.ViewModels.Employees;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        [HttpGet]
        public ViewResult Default()
        {
            var model = this.employeeRepository.GetAllEmployees();
            return View(model);
        }

        [HttpGet]
        public ViewResult Details(int? id)
         {
            EmployeeDetailsViewModel employeeDetailsViewModel = new EmployeeDetailsViewModel()
            {
                Employee = this.employeeRepository.GetEmployee(id ?? 1),
                
            };

            return View(employeeDetailsViewModel);
        }

        [HttpGet]
        // returns the create view
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee, Office office)
        {
            if (ModelState.IsValid)
            {
                var addedEmployee = this.employeeRepository.Add(employee, office);
                
                return RedirectToAction("details", new { id = addedEmployee.Id });
            }

            return View();

            //TODO: How to bind and input offices in both Employees and Companies forms !!
        }

    }
}
