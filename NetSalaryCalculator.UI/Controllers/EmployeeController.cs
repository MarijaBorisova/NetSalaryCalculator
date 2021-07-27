using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetSalaryCalculator.UI.Models;
using NetSalaryCalculator.BLL;
using NetSalaryCalculator.Entity;
using NetSalaryCalculator.DAL;
using AutoMapper;

namespace NetSalaryCalculator.UI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IMapper _mapper;

        public EmployeeController ( IMapper mapper )
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var calculatorAction = new NetSalaryCalculatorAction();

            IEnumerable<EmployeeViewModel> employees;
            var employeeDto = calculatorAction.GetEmployees();

            return View(_mapper.Map<IEnumerable<EmployeeViewModel>>(employeeDto));
        }
           
    }
}
