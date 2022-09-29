using Kod.Application.Abstractions.Repositories;
using Kod.Domain.Models;
using Kod.Infrastructure.Database.EntityFramework.Contexts;


namespace Kod.Infrastructure.Database.EntityFramework.Repositories
{
    internal class CategoriRepository : EfRepositoryBase<Categori, KodContext>, ICategoriRepository
    {
        public CategoriRepository(KodContext context) : base(context)
        {
        }
    }
}
