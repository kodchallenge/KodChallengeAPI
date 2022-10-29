using Kod.Application.Abstractions.Repositories;
using Kod.Domain.Models;
using Kod.Infrastructure.Database.EntityFramework.Contexts;

namespace Kod.Infrastructure.Database.EntityFramework.Repositories;

internal class ProblemsRepository : EfRepositoryBase<Problems, KodContext>, IProblemsRepository
{
    public ProblemsRepository(KodContext context) : base(context)
    {
    }
}
