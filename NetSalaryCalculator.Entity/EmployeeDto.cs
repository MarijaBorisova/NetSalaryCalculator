using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSalaryCalculator.Entity
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobRole { get; set; }
        public decimal GrossSalary { get; set; }
        
    }
}
