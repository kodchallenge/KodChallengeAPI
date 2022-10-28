using Kod.Application.Abstractions.Repositories;
using Kod.Domain.Models;
using Kod.Infrastructure.Database.EntityFramework.Contexts;

namespace Kod.Infrastructure.Database.EntityFramework.Repositories;

internal class UsersRepository : EfRepositoryBase<Users, KodContext>, IUsersRepository
{
    public UsersRepository(KodContext context) : base(context)
    {
    }
}