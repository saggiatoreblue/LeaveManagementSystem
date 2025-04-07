using LeaveManagementSystem.Web.Models.LeaveTypes;

namespace LeaveManagementSystem.Web.Services.LeaveTypes
{
    public interface ILeaveTypesService
    {
        Task Create(LeaveTypeCreateVM model);
        Task Edit(LeaveTypeEditVM model);
        Task<T?> Get<T>(int id) where T : class;
        Task<List<LeaveTypeReadOnlyVM>> GetAll();
        Task Remove(int id);
        bool LeaveTypeExists(int id);
        Task<bool> CheckIfLeaveTypeNameExistsAsync(string name);
        Task<bool> CheckIfLeaveTypeNameExistsEditAsync(LeaveTypeEditVM leaveTypeEdit);
        Task<bool> DaysExceedMaximum(int leaveTypeId, int days);
    }
}