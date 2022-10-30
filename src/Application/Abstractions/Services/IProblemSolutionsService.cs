using Kod.Domain.Models;
using System.Linq.Expressions;

namespace Kod.Application.Abstractions.Services
{
    public interface IProblemSolutionsService : IBaseService<ProblemSolutions>
    {
        Task<ProblemSolutions> AddAsync(ProblemSolutions problemSolution);
        Task<List<ProblemSolutions>> GetListAsync(Expression<Func<ProblemSolutions, bool>>? predicate);

        Task<ProblemSolutions> UpdateAsync(ProblemSolutions problemSolution);

        Task<ProblemSolutions> DeleteAsync(ProblemSolutions problemSolution);
    }
}
