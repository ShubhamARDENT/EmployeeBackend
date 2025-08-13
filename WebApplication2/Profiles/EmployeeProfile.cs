using AutoMapper;
using WebApplication2.Models;
using WebApplication2.Models.Entities;

namespace WebApplication2.Profiles
{
    public class EmployeeProfile :Profile
    {
        public EmployeeProfile()
        {
            CreateMap<AddEmployeeDTO, Employee>();
            CreateMap<UpdateEmployeeDTO , Employee>();

        }
    }
}
