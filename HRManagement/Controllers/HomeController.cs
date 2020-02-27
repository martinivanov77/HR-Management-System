using HRManagement.Models;
using HRManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HRManagement.Controllers
{

    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Index");
        }
    }
}
