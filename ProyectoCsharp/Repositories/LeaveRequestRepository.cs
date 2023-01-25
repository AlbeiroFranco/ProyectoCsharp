using ProyectoCsharp.Contracts;
using ProyectoCsharp.Data;

namespace ProyectoCsharp.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        public LeaveRequestRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
