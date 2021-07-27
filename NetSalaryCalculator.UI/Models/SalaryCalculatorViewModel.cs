using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetSalaryCalculator.UI.Models
{
    public class SalaryCalculatorViewModel
    {
        public string name { get; set; }
        public decimal grossSalary { get; set; }
        public decimal socialTax { get; set; }

        public int dependent { get; set; }
        public decimal incomeTax { get; set; }
        public decimal netSalary { get; set; }


    }
}
