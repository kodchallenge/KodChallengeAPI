
using Kod.Core.Domain.Abstractions;
using Kod.Core.Domain.Models;
using Kod.Domain.Models;

namespace Kod.Application.Abstractions.Services;
public interface IUserService : IBaseService<User>
{
    Task<Paginate<User>> GetListWithPaginate(IPaginateRequest request);
}
