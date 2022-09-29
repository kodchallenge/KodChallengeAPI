
using Kod.Domain.Models;
using System.Linq.Expressions;

namespace Kod.Application.Abstractions.Services
{
    public interface IProblemService : IBaseService<Problem>
    {
        Task<Problem> AddAsync(Problem lang);
        Task<List<Problem>> GetListAsync(Expression<Func<Problem, bool>>? predicate);
    }
}
