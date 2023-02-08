using AutoMapper;
using Microsoft.AspNetCore.Identity;
using ProyectoCsharp.Contracts;
using ProyectoCsharp.Data;
using ProyectoCsharp.Models;

namespace ProyectoCsharp.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<Employee> _userManager;

        public LeaveRequestRepository(ApplicationDbContext context, 
            IMapper mapper, 
            IHttpContextAccessor httpContextAccessor,
            UserManager<Employee> userManager) : base(context)
        {
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        public async Task CreateLeaveRequest(LeaveRequestCreateVM model)
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor?.HttpContext?.User);

            var leaveRequest = _mapper.Map<LeaveRequest>(model);
            leaveRequest.DateRequest = DateTime.Now;
            leaveRequest.RequestingEmployeeId = user.Id;

            await AddAsync(leaveRequest);

        }

        
    }
}
