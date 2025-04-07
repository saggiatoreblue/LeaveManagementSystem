
using AutoMapper;
using LeaveManagementSystem.Web.Models.LeaveAllocations;
using LeaveManagementSystem.Web.Services.Periods;
using LeaveManagementSystem.Web.Services.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Services.LeaveAllocations
{
    public class LeaveAllocationsService(
        IUserService _userService,
        IPeriodsService _periodsService,
        IMapper _mapper,
        ApplicationDbContext _context,
        IHttpContextAccessor _httpContextAccessor)
        : ILeaveAllocationsService
    {
        public async Task AllocateLeave(string employeeId)
        {
            // get all the leave types
            var leaveTypes = await _context.LeaveTypes.Where(q => !q.LeaveAllocations.Any(x => x.EmployeeId == employeeId)).ToListAsync();

            var currentDate = DateTime.Now;

            var period = await _periodsService.GetCurrentPeriod();

            var monthsRemaining = period.EndDate.Month - currentDate.Month;

            foreach (var leaveType in leaveTypes)
            {
                var allocationExists = await AllocationExists(employeeId, period.Id, leaveType.Id);
                var accrualRate = decimal.Divide(leaveType.NumberOfDays, 12);
                var leaveAllocation = new LeaveAllocation
                {
                    EmployeeId = employeeId,
                    LeaveTypeId = leaveType.Id,
                    PeriodId = period.Id,
                    Days = (int)Math.Ceiling(accrualRate * monthsRemaining)

                };

                _context.Add(leaveAllocation);
            }
            await _context.SaveChangesAsync();

        }

        public async Task<LeaveAllocation> GetCurrentAllocation(int leaveTypeId, string employeeId)
        {
            var period = await _periodsService.GetCurrentPeriod();
            var allocation = await _context.LeaveAllocations
                    .FirstAsync(q => q.LeaveTypeId == leaveTypeId
                    && q.EmployeeId == employeeId
                    && q.PeriodId == period.Id);
            return allocation;
        }

        public async Task EditAllocation(LeaveAllocationEditVM allocationEditVM)
        {
            await _context.LeaveAllocations
                 .Where(q => q.Id == allocationEditVM.Id)
                 .ExecuteUpdateAsync(s => s.SetProperty(e => e.Days, allocationEditVM.Days));
        }


        public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string? userId)
        {

            var user = string.IsNullOrEmpty(userId)
                ?
                await _userService.GetLoggedInUser()
                :
                await _userService.GetUserById(userId);


            var allocations = await GetAllocations(user.Id);
            var allocationVMList = _mapper.Map<List<LeaveAllocation>, List<LeaveAllocationVM>>(allocations);

            var leaveTypesCount = await _context.LeaveTypes.CountAsync();


            var employeeVM = new EmployeeAllocationVM
            {
                DateOfBirth = user.DateOfBirth,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Id = user.Id,
                LeaveAllocations = allocationVMList,
                isCompletedAllocation = leaveTypesCount == allocations.Count
            };

            return employeeVM;
        }


        public async Task<LeaveAllocationEditVM> GetEmployeeAllocation(int allocationId)
        {
            var allocation = await _context.LeaveAllocations
                .Include(q => q.LeaveType)
                .Include(q => q.Employee)
                .FirstOrDefaultAsync(q => q.Id == allocationId);

            var model = _mapper.Map<LeaveAllocationEditVM>(allocation);

            return model;
        }

        public async Task<List<EmployeeListVM>> GetEmployees()
        {
            var users = await _userService.GetEmployees();

            var employees = _mapper.Map<List<ApplicationUser>, List<EmployeeListVM>>(users.ToList());

            return employees;
        }


        private async Task<List<LeaveAllocation>> GetAllocations(string? userId)
        {


            var currentDate = DateTime.Now;

            var leaveAllocations = await _context.LeaveAllocations
                .Include(l => l.LeaveType)
                .Include(l => l.Period)
                .Where(q => q.EmployeeId == userId && q.Period.EndDate.Year == currentDate.Year)
                .ToListAsync();

            return leaveAllocations;
        }

        private async Task<bool> AllocationExists(string userId, int periodId, int leaveTypeId)
        {
            var exists = await _context.LeaveAllocations.AnyAsync(q =>

                q.EmployeeId == userId &&
                q.PeriodId == periodId &&
                q.LeaveTypeId == leaveTypeId
            );

            return exists;
        }



    }


}
