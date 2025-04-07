using AutoMapper;
using LeaveManagementSystem.Web.Models.LeaveTypes;

namespace LeaveManagementSystem.Web.MappingProfiles
{
    public class AutoMappingProfile : Profile
    {
        public AutoMappingProfile()
        {
            CreateMap<LeaveType, LeaveTypeReadOnlyVM>();

            CreateMap<LeaveTypeCreateVM, LeaveType>();

            CreateMap<LeaveTypeEditVM, LeaveType>().ReverseMap();

        }
    }
}
