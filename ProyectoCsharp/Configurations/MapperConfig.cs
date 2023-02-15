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
            CreateMap<Employee, EmployeeListVM>().ReverseMap();
            CreateMap<Employee, EmployeeAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation, EditLeaveAllocationVM>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestCreateVM>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestVM>().ReverseMap();

        }

    }
}
