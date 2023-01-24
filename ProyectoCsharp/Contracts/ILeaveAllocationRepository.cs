using ProyectoCsharp.Data;
using ProyectoCsharp.Models;

namespace ProyectoCsharp.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int leaveTypeId);
        Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);
        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);
        Task<EditLeaveAllocationVM> GetEmployeeAllocation(int id);
        Task<bool> UpdateEmployeeAllocation(EditLeaveAllocationVM model);
    }
}
