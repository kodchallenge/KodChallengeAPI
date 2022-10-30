using Kod.Application.Abstractions.Services;
using Kod.Domain.Models;
using System.Linq.Expressions;

namespace Kod.Application.Managers
{
    public class ScriptedProblemsManager : BaseManager<ScriptedProblems>, IScriptedProblemsService
    {
        public Task<ScriptedProblems> AddAsync(ScriptedProblems scriptedProblem)
        {
            throw new NotImplementedException();
        }

        public Task<ScriptedProblems> DeleteAsync(ScriptedProblems scriptedProblem)
        {
            throw new NotImplementedException();
        }

        public Task<List<ScriptedProblems>> GetListAsync(Expression<Func<ScriptedProblems, bool>>? predicate)
        {
            throw new NotImplementedException();
        }

        public Task<ScriptedProblems> UpdateAsync(ScriptedProblems scriptedProblem)
        {
            throw new NotImplementedException();
        }
    }
}
