using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProyectoCsharp.Constants;
using ProyectoCsharp.Contracts;
using ProyectoCsharp.Data;
using ProyectoCsharp.Models;



namespace ProyectoCsharp.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly UserManager<Empleado> _userManager;
        private readonly IMapper _mapper;
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public EmployeesController(UserManager<Empleado> userManager,
            IMapper mapper,
            ILeaveAllocationRepository leaveAllocationRepository,
            ILeaveTypeRepository leaveTypeRepository
            )
        {
            _userManager = userManager;
            _mapper = mapper;
            _leaveAllocationRepository = leaveAllocationRepository;
            _leaveTypeRepository = leaveTypeRepository;
        }
        // GET: EmployeesController
        public async Task<IActionResult> Index()
        {
            var employees = await _userManager.GetUsersInRoleAsync(Roles.user);
            var model = _mapper.Map<List<EmployeeListVM>>(employees);
            return View(model);
        }

        // GET: EmployeesController/ViewAllocations/5
        public async Task<ActionResult> ViewAllocations(string id)
        {
            var model = await _leaveAllocationRepository.GetEmployeeAllocations(id);
            return View(model);
        }

        // GET: EmployeesController/Create
       

        // GET: EmployeesController/Edit/5
        public async Task<ActionResult> EditAllocation(int id)
        {
            var model = await _leaveAllocationRepository.GetEmployeeAllocation(id);

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAllocation(int id, EditLeaveAllocationVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (await _leaveAllocationRepository.UpdateEmployeeAllocation(model) == true)
                        return RedirectToAction(nameof(ViewAllocations), new { id = model.EmployeeId });
                }

            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An error ocurred. Please try again later");
            }

            model.Employee = _mapper.Map<EmployeeListVM>(await _userManager.FindByIdAsync(model.EmployeeId));
            model.LeaveType = _mapper.Map<LeaveTypeVM>(await _leaveTypeRepository.GetAsync(model.LeaveTypeId));
            return View(model);
        }
    }
}
