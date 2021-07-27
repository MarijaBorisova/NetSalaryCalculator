using System;
using NetSalaryCalculator.Entity;
using NetSalaryCalculator.UI.Models;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetSalaryCalculator.UI.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<ManagerViewModel, ManagerDto>();

            CreateMap<ManagerDto, ManagerViewModel>();
            CreateMap<EmployeeDto, EmployeeViewModel>();

            CreateMap<EmployeeViewModel, EmployeeDto> ();
            CreateMap<IEnumerable<EmployeeViewModel>, IEnumerable<EmployeeDto>> ();
        }
    }
}
