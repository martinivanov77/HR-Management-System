using HRManagement.Models;
using HRManagement.ViewModels.Companies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly ICompanyRepository companyRepository;

        public CompaniesController(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }

        public ViewResult Default()
        {
            var model = this.companyRepository.GetAllCompanies();
            return View(model);
        }

        public ViewResult Details(int? id)
        {
            CompanyDetailsViewModel companyDetailsViewModel = new CompanyDetailsViewModel()
            {
                Company = this.companyRepository.GetCompany(id ?? 1),
            };

            return View(companyDetailsViewModel);
        }

        public ViewResult Create()
        {
            return View();
        }
    }
}
