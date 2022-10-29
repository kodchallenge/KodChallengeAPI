using Kod.Application.Abstractions.Repositories;
using Kod.Domain.Models;
using Kod.Infrastructure.Database.EntityFramework.Contexts;

namespace Kod.Infrastructure.Database.EntityFramework.Repositories;

internal class ScriptedProblemsRepository : EfRepositoryBase<ScriptedProblems, KodContext>, IScriptedProblemsRepository
{
    public ScriptedProblemsRepository(KodContext context) : base(context)
    {
    }
}
