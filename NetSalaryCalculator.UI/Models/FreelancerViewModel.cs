using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetSalaryCalculator.UI.Models
{
    public class FreelancerViewModel
    {
        public string Name { get; set; }
        public string JobRole { get; set; }
        public decimal GrossSalary { get; set; }
        public decimal WorkingHours { get; set; }
    }
}
