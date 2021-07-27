using NetSalaryCalculator.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using NetSalaryCalculator.DAL;

namespace NetSalaryCalculator.DAL
{
    public class EmployeeRepository
    {
        
        
        public IEnumerable<EmployeeDto> GetEmployees()
        {
            
            using (var context = new EFDbContext()) 
            {
                return context.Employees.Where(x => x.JobRole == "Employee" ).ToList();
            }
               
        }

        public EmployeeDto GetEmployeeByJobRole(string jobrole)
        {
            using (var context = new EFDbContext())
            {
                return context.Employees.FirstOrDefault(x => x.JobRole == jobrole);
            }
        }
        
    }    
        
    }


