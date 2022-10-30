using Kod.Core.Domain.Abstractions;
using Kod.Core.Domain.Models;
using Kod.Domain.Models;

namespace Kod.Application.Abstractions.Services;
public interface IUsersService : IBaseService<Users>
{
    Task<Paginate<Users>> GetListWithPaginate(IPaginateRequest request);


    Task<Users> UpdateAsync(Users user);

    Task<Users> DeleteAsync(Users user);
}
