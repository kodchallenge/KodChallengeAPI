using Kod.Domain.Models;
using System.Linq.Expressions;

namespace Kod.Application.Abstractions.Services
{
    public interface IProblemsService : IBaseService<Problems>
    {
        Task<Problems> AddAsync(Problems problem);
        Task<List<Problems>> GetListAsync(Expression<Func<Problems, bool>>? predicate);

        Task<Problems> UpdateAsync(Problems problem);

        Task<Problems> DeleteAsync(Problems problem);
    }
}
