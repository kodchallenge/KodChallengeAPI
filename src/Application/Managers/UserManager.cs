
using Kod.Application.Abstractions.Repositories;
using Kod.Application.Abstractions.Services;
using Kod.Core.Domain.Abstractions;
using Kod.Core.Domain.Models;
using Kod.Domain.Models;
using Microsoft.Extensions.Logging;

namespace Kod.Application.Managers;
public class UserManager : BaseManager<User>, IUserService
{
    private readonly ILogger _logger;
    private readonly IUserRepository _userRepository;

    public UserManager(IUserRepository userRepository, ILogger<UserManager> logger)
    {
        _userRepository = userRepository;
        _logger = logger;
    }

    public async Task<Paginate<User>> GetListWithPaginate(IPaginateRequest request)
    {
        _logger.LogInformation($"GetListUsersWithPaginate started with @request = {request}");
        
        var list = await _userRepository.GetListWithPaginateAsync(x => !x.IsDeleted, request, null);
        
        _logger.LogInformation($"GetListUsersWithPaginate finished with @list={list}");
        return list;
    }
}
