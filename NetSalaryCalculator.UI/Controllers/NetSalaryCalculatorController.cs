using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetSalaryCalculator.UI.Models;
using NetSalaryCalculator.BLL;
using NetSalaryCalculator.Entity;
using NetSalaryCalculator.DAL;

namespace NetSalaryCalculator.UI.Controllers // The actions are here.
{
    public class NetSalaryCalculatorController : Controller
    {
        public IActionResult Index()
        {
            ManagerViewModel managerModel = new ManagerViewModel()
            {
                Name = "Bob Smith", // initilize a new object, a new model
                JobRole = "Manager",
                GrossSalary = 2000,
                WorkingHours = 8,
                Date = new DateTime(2021, 6, 23)
            };
            ManagerDto managerDto = new ManagerDto()
            {
                Name = "Tom Black", 
                JobRole = "Manager",
                GrossSalary = 1400,
                WorkingHours = 8,
                //Date = 01/06/2021
            };    

            NetSalaryCalculatorAction managerAction = new NetSalaryCalculatorAction();

            managerModel.newUser = managerAction.getManagertFullInfo(managerDto); // create Business logic instance which contains method

            return View(managerModel); // our model will be  passed into View GetNetSalaryInfo.cshtml
            // and will be discovered in Index
        }
    }
}
