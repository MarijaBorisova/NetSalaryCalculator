using Microsoft.AspNetCore.Mvc;
using NetSalaryCalculator.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace NetSalaryCalculator.UI.Controllers
{
    public class SalaryCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View(new SalaryCalculatorViewModel());
        }
        [HttpPost]

        public IActionResult Index(SalaryCalculatorViewModel s)
        {            
            const int incTaxRate1 = 20;
            const int incTaxRate2 = 23;
            const int monthIncLimit = 1667;
            //const int dep = 250;


            if (s.grossSalary > monthIncLimit)
            {
                s.socialTax = Math.Round(s.grossSalary * 105 / 1000, 2, MidpointRounding.AwayFromZero);
                s.incomeTax = Math.Round((monthIncLimit- s.socialTax) * 20/100, 2, MidpointRounding.AwayFromZero) 
                    + Math.Round((s.grossSalary - monthIncLimit) * incTaxRate2/100, 2, MidpointRounding.AwayFromZero);
            }
            else 
            {
                s.socialTax = Math.Round(s.grossSalary * 105/1000, 2, MidpointRounding.AwayFromZero);
                s.incomeTax = Math.Round((s.grossSalary - s.socialTax) * incTaxRate1/100, 2, MidpointRounding.AwayFromZero);
            }

            s.netSalary = Math.Round(s.grossSalary - s.socialTax - s.incomeTax, 2, MidpointRounding.AwayFromZero);            
            return View(s);
        }
    }
}
