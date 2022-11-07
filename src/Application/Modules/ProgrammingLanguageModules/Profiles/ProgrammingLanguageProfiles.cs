using AutoMapper;
using Kod.Application.Modules.ProgrammingLanguageModules.Queries;
using Kod.Domain.Models;

namespace Kod.Application.Modules.ProgrammingLanguageModules.Profiles
{
    public class ProgrammingLanguageProfiles : Profile
    {
        public ProgrammingLanguageProfiles()
        {
            CreateMap<ProgrammingLanguages, GetAllProgrammingLanguagesQuery>().ReverseMap();
        }
    }
}
