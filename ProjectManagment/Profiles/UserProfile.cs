using AutoMapper;
using ProjectManagment.ExternalModels;
using ProjectManagment.Models;

namespace ProjectManagment.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserModel>()
                .ForMember(m => m.FullName, o => o.MapFrom(s => s.FirstName + " " +s.LastName));
        }
    }
}