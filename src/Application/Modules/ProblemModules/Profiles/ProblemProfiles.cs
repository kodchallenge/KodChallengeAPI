using AutoMapper;
using Kod.Application.Modules.ProblemModules.Queries;
using Kod.Domain.Models;

namespace Kod.Application.Modules.ProblemModules.Profiles
{
    public class ProblemProfiles : Profile
    {
        public ProblemProfiles()
        {
            CreateMap<Problems, GetAllProblemsQueryResponse>().ReverseMap();
            CreateMap<Problems, GetProblemQueryResponse>().ReverseMap();
        }
    }
}
