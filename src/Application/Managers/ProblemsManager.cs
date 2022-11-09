using Kod.Application.Abstractions.Repositories;
using Kod.Application.Abstractions.Services;
using Kod.Application.Constants.Messages;
using Kod.Core.Exceptions;
using Kod.Domain.Models;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace Kod.Application.Managers
{
    public class ProblemsManager : BaseManager<Problems>, IProblemsService
    {
        private readonly ILogger _logger;
        private readonly IProblemsRepository _problemRepository;

        public ProblemsManager(IProblemsRepository problemRepository, ILogger<Problems> logger)
        {
            _logger = logger;   
            _problemRepository = problemRepository;
        }

        public async Task<Problems> AddAsync(Problems problem)
        {
            // TODO:: Searching without Id
            _logger.LogInformation($"AddProblemsAsync method started with @problem={problem}");
            var isExistsName = await _problemRepository.GetAsync(x => x.Id.Equals(problem.Id));
            if (isExistsName != null)
            {
                throw new InternalException(Messages.DublicatedName);
            }

            var addedProblem = await _problemRepository.AddAsync(problem);

            _logger.LogInformation($"AddProblemsAsync method finished with @addedProblem={addedProblem}");
            return addedProblem;
        }

        public async Task<Problems> DeleteAsync(Problems problem)
        {
            // TODO:: Searching without Id
            _logger.LogInformation($"DeleteProblemsAsync method started with @problem={problem}");
            var isExist = await _problemRepository.GetAsync(x => x.Id.Equals(problem.Id));
            if (isExist == null)
            {
                throw new InternalException(Messages.NotExist);
            }
            await _problemRepository.DeleteAsync(problem);
            _logger.LogInformation($"DeleteProblemsAsync method finished with @deletedProblem={problem}");
            return problem;
        }

        public async Task<Problems> GetByIdAsync(int id)
        {
            _logger.LogInformation($"GetProblemByIdAsync method started with @id={id}");

            var isExist = await _problemRepository.GetAsync(x=>x.Id.Equals(id));
            if (isExist == null)
            {
                throw new InternalException(Messages.NotExist);
            }

            _logger.LogInformation($"GetProblemByIdAsync method finished with @problem={isExist}");

            return isExist;
        }

        public async Task<List<Problems>> GetListAsync(Expression<Func<Problems, bool>>? predicate)
        {
            _logger.LogInformation($"GetProblemsListAsync method started with @predicate={predicate}");

            var list = await _problemRepository.GetListAysnc(predicate);

            _logger.LogInformation($"GetProblemsListAsync method finished with @list={list}");

            return list.ToList();
        }

        public async Task<Problems> UpdateAsync(Problems problem)
        {
            _logger.LogInformation($"UpdateProblemsAsync method started with @problem={problem}");
            var isExistName = await _problemRepository.GetAsync(x => x.Id == problem.Id);
            if (isExistName == null)
            {
                throw new InternalException(Messages.NotExist);
            }
            isExistName.Title = problem.Title;
            isExistName.Point = problem.Point;
            isExistName.IsPrivate = problem.IsPrivate;
            isExistName.Description = problem.Description; 
            isExistName.CategoriId = problem.CategoriId;
            var updatedProblem = await _problemRepository.UpdateAsync(isExistName);
            _logger.LogInformation($"UpdatedProblemsAsync method finished with @updatedProblem={updatedProblem}");
            return updatedProblem;
        }
    }
}
