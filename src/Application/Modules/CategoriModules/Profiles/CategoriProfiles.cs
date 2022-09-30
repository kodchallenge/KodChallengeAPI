
using AutoMapper;
using Kod.Application.Modules.CategoriesModules.Queries;
using Kod.Domain.Models;

namespace Kod.Application.Modules.CategoriesModules.Profiles
{
    public class CategoriProfiles : Profile
    {
        public CategoriProfiles()
        {
            CreateMap<Categories, GetAllCategoriQuery>().ReverseMap();
        }
    }
}
