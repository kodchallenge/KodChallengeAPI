
using Kod.Core.Domain.Abstractions;
using Kod.Core.Domain.Models;
using Kod.Domain.Models;

namespace Kod.Application.Abstractions.Services;
public interface IUsersService : IBaseService<Users>
{
    Task<Paginate<Users>> GetListWithPaginate(IPaginateRequest request);
}
