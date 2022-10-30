using Kod.Application.Abstractions.Services;
using Kod.Domain.Models;
using System.Linq.Expressions;

namespace Kod.Application.Managers
{
    public class UserSolutionsManager : BaseManager<UserSolutions>, IUserSolutionsService
    {
        public Task<UserSolutions> AddAsync(UserSolutions userSolution)
        {
            throw new NotImplementedException();
        }

        public Task<UserSolutions> DeleteAsync(UserSolutions userSolution)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserSolutions>> GetListAsync(Expression<Func<UserSolutions, bool>>? predicate)
        {
            throw new NotImplementedException();
        }

        public Task<UserSolutions> UpdateAsync(UserSolutions userSolution)
        {
            throw new NotImplementedException();
        }
    }
}
