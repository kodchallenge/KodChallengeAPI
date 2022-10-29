using Kod.Application.Abstractions.Repositories;
using Kod.Domain.Models;
using Kod.Infrastructure.Database.EntityFramework.Contexts;


namespace Kod.Infrastructure.Database.EntityFramework.Repositories;

internal class CategoriesRepository : EfRepositoryBase<Categories, KodContext>, ICategoriesRepository
{
    public CategoriesRepository(KodContext context) : base(context)
    {
    }
}
