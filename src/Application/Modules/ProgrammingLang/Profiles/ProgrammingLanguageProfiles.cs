using AutoMapper;
using Kod.Application.Modules.ProgrammingLang.Queries;
using Kod.Domain.Models;

namespace Kod.Application.Modules.ProgrammingLang.Profiles
{
    public class ProgrammingLanguageProfiles : Profile
    {
        public ProgrammingLanguageProfiles()
        {
            CreateMap<ProgrammingLanguages, GetAllProgrammingLanguagesQuery>().ReverseMap();
        }
    }
}
