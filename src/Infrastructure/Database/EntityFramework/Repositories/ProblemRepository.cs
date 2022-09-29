
using Kod.Application.Abstractions.Repositories;
using Kod.Domain.Models;
using Kod.Infrastructure.Database.EntityFramework.Contexts;

namespace Kod.Infrastructure.Database.EntityFramework.Repositories
{
    internal class ProblemRepository : EfRepositoryBase<Problem, KodContext>, IProblemRepository
    {
        public ProblemRepository(KodContext context) : base(context)
        {
        }
    }
}
