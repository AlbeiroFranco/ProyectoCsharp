using ProyectoCsharp.Contracts;
using ProyectoCsharp.Data;

namespace ProyectoCsharp.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
