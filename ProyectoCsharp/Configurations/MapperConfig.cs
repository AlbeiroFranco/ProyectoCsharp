using AutoMapper;
using ProyectoCsharp.Data;      
using ProyectoCsharp.Models;

namespace ProyectoCsharp.Configurations
{
    public class MapperConfig : Profile 
    {
        public MapperConfig() 
        { 
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
            CreateMap<Empleado, EmployeeListVM>().ReverseMap();
            CreateMap<Empleado, EmployeeAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation, EditLeaveAllocationVM>().ReverseMap();
        }
        
    }
}
