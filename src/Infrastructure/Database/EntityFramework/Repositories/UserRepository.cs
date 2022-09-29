using Kod.Application.Abstractions.Repositories;
using Kod.Domain.Models;
using Kod.Infrastructure.Database.EntityFramework.Contexts;

namespace Kod.Infrastructure.Database.EntityFramework.Repositories;

internal class UserRepository : EfRepositoryBase<User, KodContext>, IUserRepository
{
    public UserRepository(KodContext context) : base(context)
    {
    }
}