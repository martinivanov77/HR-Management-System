﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter First Name!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter Last Name!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = " Please enter Starting Date!")]
        public DateTime StartingDate { get; set; }

        [Required(ErrorMessage = "Please enter Salary!")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "Please enter Vaction Days!")]
        public int VacationDays { get; set; }
        public ExperienceLevel ExperienceLevel { get; set; }
        public  ICollection<Office> Offices { get; set; }
    }
}
