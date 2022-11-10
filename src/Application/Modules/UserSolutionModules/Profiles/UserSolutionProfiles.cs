using Application.Modules.UserSolutionModules.Queries;
using AutoMapper;
using Kod.Domain.Models;

namespace Application.Modules.UserSolutionModules.Profiles
{
    internal class UserSolutionProfiles : Profile
    {
        public UserSolutionProfiles()
        {
            CreateMap<UserSolutions, GetAllUserSolutionsQueryResponse>().ReverseMap();
            CreateMap<UserSolutions, GetUserSolutionQueryResponse>().ReverseMap();  
        }
    }
}
