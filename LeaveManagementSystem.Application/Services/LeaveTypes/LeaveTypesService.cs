using AutoMapper;
using LeaveManagementSystem.Web.Models.LeaveTypes;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Services.LeaveTypes;

public class LeaveTypesService(ApplicationDbContext _context, IMapper mapper) : ILeaveTypesService
{

    public async Task<List<LeaveTypeReadOnlyVM>> GetAll()
    {

        var data = await _context.LeaveTypes.ToListAsync();

        // conver data model to view model
        var viewData = mapper.Map<List<LeaveTypeReadOnlyVM>>(data);

        return viewData;
    }

    public async Task<T?> Get<T>(int id) where T : class
    {
        var data = await _context.LeaveTypes.FirstOrDefaultAsync(x => x.Id == id);

        if (data == null)
        {
            return null;
        }

        var viewData = mapper.Map<T>(data);

        return viewData;
    }

    public async Task Remove(int id)
    {
        var data = await _context.LeaveTypes.FirstOrDefaultAsync(x => x.Id == id);

        if (data != null)
        {
            _context.LeaveTypes.Remove(data);
            await _context.SaveChangesAsync();
        }
    }

    public async Task Edit(LeaveTypeEditVM model)
    {

        var viewModel = mapper.Map<LeaveType>(model);
        _context.Update(viewModel);
        await _context.SaveChangesAsync();
    }


    public async Task Create(LeaveTypeCreateVM model)
    {
        var leaveType = mapper.Map<LeaveType>(model);
        _context.Add(leaveType);
        await _context.SaveChangesAsync();

    }

    public bool LeaveTypeExists(int id)
    {
        return _context.LeaveTypes.Any(e => e.Id == id);
    }

    public async Task<bool> CheckIfLeaveTypeNameExistsAsync(string name)
    {
        var lowerCaseName = name.ToLower();
        return await _context.LeaveTypes.AnyAsync(m => m.Name.ToLower().Equals(lowerCaseName));
    }

    public async Task<bool> CheckIfLeaveTypeNameExistsEditAsync(LeaveTypeEditVM leaveTypeEdit)
    {
        var lowerCaseName = leaveTypeEdit.Name.ToLower();
        return await _context.LeaveTypes.AnyAsync(m => m.Name.ToLower().Equals(lowerCaseName) && m.Id != leaveTypeEdit.Id);
    }

    public async Task<bool> DaysExceedMaximum(int leaveTypeId, int days)
    {
        var leaveType = await _context.LeaveTypes.FindAsync(leaveTypeId);
        return leaveType.NumberOfDays < days;
    }
}
