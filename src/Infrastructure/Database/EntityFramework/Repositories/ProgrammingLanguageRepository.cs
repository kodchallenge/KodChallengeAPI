using Kod.Application.Abstractions.Repositories;
using Kod.Core.Infrastructure.Database.EntityFramework;
using Kod.Domain.Models;
using Kod.Infrastructure.Database.EntityFramework.Contexts;

namespace Kod.Infrastructure.Database.EntityFramework.Repositories
{
    internal class ProgrammingLanguageRepository : EfRepositoryBase<ProgrammingLanguage, KodContext>, IProgrammingLanguageRepository
    {
        public ProgrammingLanguageRepository(KodContext context) : base(context)
        {
        }
    }
}
