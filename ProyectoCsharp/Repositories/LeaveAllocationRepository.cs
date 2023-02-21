using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using ProyectoCsharp.Constants;
using ProyectoCsharp.Contracts;
using ProyectoCsharp.Data;
using ProyectoCsharp.Data.Migrations;
using ProyectoCsharp.Models;

namespace ProyectoCsharp.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Employee> _userManager;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly AutoMapper.IConfigurationProvider _configurationProvider;
        private readonly IEmailSender _emailSender;
        private readonly IMapper _mapper;

        public LeaveAllocationRepository(ApplicationDbContext context,
            UserManager<Employee> userManager,
            ILeaveTypeRepository leaveTypeRepository,
            AutoMapper.IConfigurationProvider configurationProvider,
            IEmailSender emailSender,
            IMapper mapper) : base(context)

        {
            _context = context;
            _userManager = userManager;
            _leaveTypeRepository = leaveTypeRepository;
            _configurationProvider = configurationProvider;
            _emailSender = emailSender;
            _mapper = mapper;
        }

        public async Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period)
        {
            return await _context.LeaveAllocation.AnyAsync(q => q.EmployeeId == employeeId
                                                                && q.LeaveTypeId == leaveTypeId
                                                                && q.Period == period);
        }

        public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId)
        {
            var allocations = await _context.LeaveAllocation
                .Include(q => q.LeaveType)
                .Where(q => q.EmployeeId == employeeId)
                .ProjectTo<LeaveAllocationVM>(_configurationProvider)
                .ToListAsync();

            var employee = await _userManager.FindByIdAsync(employeeId);

            var employeeAllocationModel = _mapper.Map<EmployeeAllocationVM>(employee);
            employeeAllocationModel.LeaveAllocations = allocations;

            return employeeAllocationModel;
        }

        public async Task<EditLeaveAllocationVM> GetEmployeeAllocation(int id)
        {
            var allocation = await _context.LeaveAllocation
                .Include(q => q.LeaveType)
                .ProjectTo<EditLeaveAllocationVM>(_configurationProvider)
                .FirstOrDefaultAsync(q => q.Id == id);

            if (allocation == null)
            {
                return null;
            }

            var employee = await _userManager.FindByIdAsync(allocation.EmployeeId);

            var model = _mapper.Map<EditLeaveAllocationVM>(allocation);
            model.Employee = _mapper.Map<EmployeeListVM>(await _userManager.FindByIdAsync(allocation.EmployeeId));

            return model;
        }

        public async Task LeaveAllocation(int leaveTypeId)
        {
            var employees = await _userManager.GetUsersInRoleAsync(Roles.user);
            var period = DateTime.Now.Year;
            var leaveType = await _leaveTypeRepository.GetAsync(leaveTypeId);
            var allocations = new List<LeaveAllocation>();
            var employeesNewAllocations = new List<Employee>();

            foreach (var employee in employees)
            {
                if (await AllocationExists(employee.Id, leaveTypeId, period))
                    continue;

                allocations.Add(new LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = leaveTypeId,
                    Period = period,
                    NumberOfDays = leaveType.Days
                });
                employeesNewAllocations.Add(employee);
            }

            await AddRangeAsync(allocations);

            foreach (var employee in employeesNewAllocations)
            {
                await _emailSender.SendEmailAsync(employee.Email, "Leave allocation posted for ${period} ", $"Your {leaveType.Name} " + $"has been posted for the period of ${period}. You have been given {leaveType.Days}");
            }
        }

        public async Task<bool> UpdateEmployeeAllocation(EditLeaveAllocationVM model)
        {
            var leaveAllocation = await GetAsync(model.Id);
            if (leaveAllocation == null)
            {
                return false;
            }
            leaveAllocation.Period = model.Period;
            leaveAllocation.NumberOfDays = model.NumberOfDays;
            await UpdateAsync(leaveAllocation);

            var user = await _userManager.FindByIdAsync(leaveAllocation.EmployeeId);

            await _emailSender.SendEmailAsync(user.Email, $"Leave allocation update for {leaveAllocation.Period} ", $"Please review your leave allocations.");

            return true;
        }

        public async Task<LeaveAllocation?> GetEmployeeAllocation(string employeeId, int leaveTypeId)
        {
            return await _context.LeaveAllocation.FirstOrDefaultAsync(q => q.EmployeeId == employeeId && q.LeaveTypeId == leaveTypeId);
        }
    }
}
