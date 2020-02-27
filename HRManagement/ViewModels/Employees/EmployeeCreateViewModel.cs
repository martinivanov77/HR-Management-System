using HRManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.ViewModels.Employees
{
    public class EmployeeCreateViewModel
    {
        public Employee Employee { get; set; }
        public Office Office { get; set; }
    }
}
