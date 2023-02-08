using ProyectoCsharp.Data;
using ProyectoCsharp.Models;

namespace ProyectoCsharp.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task CreateLeaveRequest(LeaveRequestCreateVM request);
    }
}
