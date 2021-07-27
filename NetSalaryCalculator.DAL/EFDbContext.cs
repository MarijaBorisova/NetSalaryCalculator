using Microsoft.EntityFrameworkCore;
using NetSalaryCalculator.Entity;

namespace NetSalaryCalculator.DAL
{
    public class EFDbContext : DbContext
    {
        public DbSet<EmployeeDto> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=EmployeesDb");
    }

}
