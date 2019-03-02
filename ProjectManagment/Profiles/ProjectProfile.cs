using AutoMapper;
using ProjectManagment.ExternalModels;
using ProjectManagment.Models;

namespace ProjectManagment.Profiles
{
    public class ProjectProfile : Profile
    {
        public ProjectProfile()
        {
            CreateMap<UserProject, ProjectModel>()
                .ForMember(m => m.StartDate, o => o.MapFrom(s => s.Project.StartDate.ToString("yyyy-MM-dd")))
                .ForMember(m => m.EndDate, o => o.MapFrom(s => s.Project.EndDate.ToString("yyyy-MM-dd")))
                .ForMember(m => m.Status, o => o.MapFrom(s => s.IsActive ? StatusConstants.Active : StatusConstants.Inactive))
                .ForMember(m => m.Credits, o => o.MapFrom(s => s.Project.Credits))
                .ForMember(m => m.TimeToStart, o => o.MapFrom(s => (s.Project.StartDate - s.AssignedDate).Days > 0 ? (s.Project.StartDate - s.AssignedDate).Days.ToString() : "Started"));
        }
        
    }
}