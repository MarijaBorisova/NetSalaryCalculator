using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NetSalaryCalculator.Entity
{
    public class ManagerDto // Data transfer object, contains data, doesn`t contain logic
    {
        public string Name { get; set; }
        public string JobRole { get; set; }
        public decimal GrossSalary { get; set; }
        public decimal WorkingHours { get; set; }
        public DateTime Date { get; set; }
        public string newUser { get; set; }
    }
}
