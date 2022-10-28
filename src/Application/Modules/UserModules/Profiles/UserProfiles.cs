using AutoMapper;
using Kod.Application.Modules.UserModules.Queries;
using Kod.Domain.Models;

namespace Kod.Application.Modules.ProgrammingLang.Profiles
{
    public class UserProfiles : Profile
    {
        public UserProfiles()
        {
            CreateMap<Users, GetAllUsersQueryResponse>().ReverseMap();
        }
    }
}
