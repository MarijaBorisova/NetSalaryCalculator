using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetSalaryCalculator.UI.Models;
using NetSalaryCalculator.BLL;
using NetSalaryCalculator.Entity;


namespace NetSalaryCalculator.UI.Controllers
{
    public class FreelancerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
