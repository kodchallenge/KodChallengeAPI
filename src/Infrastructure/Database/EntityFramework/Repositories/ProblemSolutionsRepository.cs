using Kod.Application.Abstractions.Repositories;
using Kod.Domain.Models;
using Kod.Infrastructure.Database.EntityFramework.Contexts;

namespace Kod.Infrastructure.Database.EntityFramework.Repositories
{
    internal class ProblemSolutionsRepository : EfRepositoryBase<ProblemSolutions, KodContext>, IProblemSolutionsRepository
    {
        public ProblemSolutionsRepository(KodContext context) : base(context)
        {
        }
    }
}
