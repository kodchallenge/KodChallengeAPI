using Kod.Application.Abstractions.Repositories;
using Kod.Infrastructure.Database.EntityFramework;
using Kod.Domain.Models;
using Kod.Infrastructure.Database.EntityFramework.Contexts;

namespace Kod.Infrastructure.Database.EntityFramework.Repositories
{
    internal class ProgrammingLanguagesRepository : EfRepositoryBase<ProgrammingLanguages, KodContext>, IProgrammingLanguagesRepository
    {
        public ProgrammingLanguagesRepository(KodContext context) : base(context)
        {
        }
    }
}
