using Kod.Domain.Models;
using System.Linq.Expressions;

namespace Kod.Application.Abstractions.Services
{
    public interface IScriptedProblemsService : IBaseService<ScriptedProblems>
    {
        Task<ScriptedProblems> AddAsync(ScriptedProblems scriptedProblem);
        Task<List<ScriptedProblems>> GetListAsync(Expression<Func<ScriptedProblems, bool>>? predicate);

        Task<ScriptedProblems> UpdateAsync(ScriptedProblems scriptedProblem);

        Task<ScriptedProblems> DeleteAsync(ScriptedProblems scriptedProblem);
    }
}
