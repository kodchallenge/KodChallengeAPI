using Kod.Application.Abstractions.Repositories;
using Kod.Application.Abstractions.Services;
using Kod.Application.Constants.Messages;
using Kod.Core.Exceptions;
using Kod.Domain.Models;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace Kod.Application.Managers
{
    public class UserSolutionsManager : BaseManager<UserSolutions>, IUserSolutionsService
    {
        private readonly ILogger _logger;
        private readonly IUserSolutionsRepository _userSolutionsRepository;

        public UserSolutionsManager(IUserSolutionsRepository userSolutionsRepository, ILogger<Problems> logger)
        {
            _logger = logger;
            _userSolutionsRepository = userSolutionsRepository;
        }
        public async Task<UserSolutions> AddAsync(UserSolutions userSolution)
        {
            _logger.LogInformation($"AddUserSolutionsAsync method started with @userSolution={userSolution}");
            var isExistsName = await _userSolutionsRepository.GetAsync(x => x.SolutionPath.Equals(userSolution.SolutionPath));
            if (isExistsName != null)
            {
                throw new InternalException(Messages.DublicatedId);
            }

            var addedUserSolution = await _userSolutionsRepository.AddAsync(userSolution);

            _logger.LogInformation($"AddUserSolutionsAsync method finished with @addedUserSolution={addedUserSolution}");
            return addedUserSolution;
        }

        public async Task<UserSolutions> DeleteAsync(UserSolutions userSolution)
        {
            _logger.LogInformation($"DeleteUserSolutionsAsync method started with @userSolution={userSolution}");
            var isExist = await _userSolutionsRepository.GetAsync(x => x.SolutionPath.Equals(userSolution.SolutionPath));
            if (isExist == null)
            {
                throw new InternalException(Messages.NotExist);
            }
            await _userSolutionsRepository.DeleteAsync(userSolution);
            _logger.LogInformation($"DeleteUserSolutionsAsync method finished with @deletedUserSolution={userSolution}");
            return userSolution;
        }

        public async Task<UserSolutions> GetByIdAsync(int id)
        {
            _logger.LogInformation($"GetUserSolutionByIdAsync method started with @id={id}");

            var isExist = await _userSolutionsRepository.GetAsync(x => x.Id.Equals(id));
            if (isExist == null)
            {
                throw new InternalException(Messages.NotExist);
            }

            _logger.LogInformation($"GetUserSolutionByIdAsync method finished with @solution={isExist}");

            return isExist;
        }

        public async Task<List<UserSolutions>> GetListAsync(Expression<Func<UserSolutions, bool>>? predicate)
        {
            _logger.LogInformation($"GetUserSolutionsListAsync method started with @predicate={predicate}");

            var list = await _userSolutionsRepository.GetListAysnc(predicate);

            _logger.LogInformation($"GetUserSolutionsListAsync method finished with @list={list}");

            return list.ToList();
        }

        public async Task<UserSolutions> UpdateAsync(UserSolutions userSolution)
        {
            // TODO:: searching without SolutionPath
            _logger.LogInformation($"UpdateUserSolutionsAsync method started with @userSolution={userSolution}");
            var isExist = await _userSolutionsRepository.GetAsync(x => x.Id.Equals(userSolution.Id));
            if (isExist == null)
            {
                throw new InternalException(Messages.NotExist);
            }
            isExist.UserId = userSolution.UserId;
            isExist.SolutionPath = userSolution.SolutionPath;
            isExist.Score = userSolution.Score;
            var updatedUserSolution = await _userSolutionsRepository.UpdateAsync(isExist);
            _logger.LogInformation($"UpdateUserSolutionsAsync method finished with @updatedUserSolution={updatedUserSolution}");
            return updatedUserSolution;
        }
    }
}
