using Kod.Application.Abstractions.Services;
using Kod.Domain.Models;
using System.Linq.Expressions;

namespace Kod.Application.Managers
{
    public class ProblemSolutionsManager : BaseManager<ProblemSolutions>, IProblemSolutionsService
    {
        public Task<ProblemSolutions> AddAsync(ProblemSolutions problemSolution)
        {
            throw new NotImplementedException();
        }

        public Task<ProblemSolutions> DeleteAsync(ProblemSolutions problemSolution)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProblemSolutions>> GetListAsync(Expression<Func<ProblemSolutions, bool>>? predicate)
        {
            throw new NotImplementedException();
        }

        public Task<ProblemSolutions> UpdateAsync(ProblemSolutions problemSolution)
        {
            throw new NotImplementedException();
        }
    }
}
