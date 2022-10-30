using Kod.Application.Abstractions.Repositories;
using Kod.Domain.Models;
using Kod.Infrastructure.Database.EntityFramework.Contexts;

namespace Kod.Infrastructure.Database.EntityFramework.Repositories;

internal class UserSolutionsRepository : EfRepositoryBase<UserSolutions, KodContext>, IUserSolutionsRepository
{
    public UserSolutionsRepository(KodContext context) : base(context)
    {
    }
}
