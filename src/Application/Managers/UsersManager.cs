using Kod.Application.Abstractions.Repositories;
using Kod.Application.Abstractions.Services;
using Kod.Application.Constants.Messages;
using Kod.Core.Domain.Abstractions;
using Kod.Core.Domain.Models;
using Kod.Core.Exceptions;
using Kod.Domain.Models;
using Microsoft.Extensions.Logging;

namespace Kod.Application.Managers;
public class UsersManager : BaseManager<Users>, IUsersService
{
    private readonly ILogger _logger;
    private readonly IUsersRepository _userRepository;

    public UsersManager(IUsersRepository userRepository, ILogger<UsersManager> logger)
    {
        _userRepository = userRepository;
        _logger = logger;
    }

    public async Task<Users> DeleteAsync(Users user)
    {
        _logger.LogInformation($"DeleteUsersAsync method started with @user={user}");
        var isExistName = await _userRepository.GetAsync(x => x.Username.Equals(user.Username));
        if (isExistName == null)
        {
            throw new InternalException(Messages.NotExist);
        }
        await _userRepository.DeleteAsync(user);
        _logger.LogInformation($"DeleteUsersAsync method finished with @deletedUser={user}");
        return user;
    }

    public async Task<Paginate<Users>> GetListWithPaginate(IPaginateRequest request)
    {
        _logger.LogInformation($"GetListUsersWithPaginate method started with @request = {request}");
        
        var list = await _userRepository.GetListWithPaginateAsync(x => !x.IsDeleted, request, null);
        
        _logger.LogInformation($"GetListUsersWithPaginate method finished with @list={list}");
        return list;
    }

    public async Task<Users> UpdateAsync(Users user)
    {
        _logger.LogInformation($"UpdateUsersAsync method started with @user={user}");
        var isExistName = await _userRepository.GetAsync(x => x.Username.Equals(user.Username));
        if (isExistName == null)
        {
            throw new InternalException(Messages.NotExist);
        }
        isExistName.FullName = user.FullName;
        isExistName.Username = user.Username;
        isExistName.Password = user.Password;
        isExistName.Email = user.Email;
        var updatedUser = await _userRepository.UpdateAsync(isExistName);
        _logger.LogInformation($"UpdateUsersAsync method finished with @updatedUser={updatedUser}");
        return updatedUser;
    }
}
