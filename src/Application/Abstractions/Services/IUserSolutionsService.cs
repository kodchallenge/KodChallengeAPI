using Kod.Domain.Models;
using System.Linq.Expressions;

namespace Kod.Application.Abstractions.Services
{
    public interface IUserSolutionsService : IBaseService<UserSolutions>
    {
        Task<UserSolutions> AddAsync(UserSolutions userSolution);
        Task<List<UserSolutions>> GetListAsync(Expression<Func<UserSolutions, bool>>? predicate);

        Task<UserSolutions> UpdateAsync(UserSolutions userSolution);

        Task<UserSolutions> DeleteAsync(UserSolutions userSolution);

        Task<UserSolutions> GetByIdAsync(int id);   
    }
}
