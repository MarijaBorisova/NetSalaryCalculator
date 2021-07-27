using System;
using System.Collections.Generic;
using NetSalaryCalculator.DAL;
using NetSalaryCalculator.Entity;

namespace NetSalaryCalculator.BLL
{
    public class NetSalaryCalculatorAction // Logic class, we usee entity objects inside BLL.
    {
        public string getManagertFullInfo(ManagerDto manager)
        {
            return $"{manager.Date}, {manager.Name}, {manager.JobRole}, {manager.GrossSalary}, {manager.WorkingHours}";
        }

        public string getEmployeeFullInfo(EmployeeDto employee)
        {
            return $"{employee.Id}, {employee.Name}, {employee.JobRole}, {employee.GrossSalary}";
        }

        public string getFreelancerFullInfo(FreelancerDto freelancer)
        {
            return $"{freelancer.Date}, {freelancer.Name}, {freelancer.JobRole}, {freelancer.GrossSalary}, {freelancer.WorkingHours}";
        }

        public IEnumerable<EmployeeDto> GetEmployees()
        {
            var employees = new EmployeeRepository ();

            return employees.GetEmployees();
        }
    }//to create the method to asks GetNetSalary method

} 
