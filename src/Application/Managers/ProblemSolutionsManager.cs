using Kod.Application.Abstractions.Repositories;
using Kod.Application.Abstractions.Services;
using Kod.Application.Constants.Messages;
using Kod.Core.Exceptions;
using Kod.Domain.Models;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace Kod.Application.Managers
{
    public class ProblemSolutionsManager : BaseManager<ProblemSolutions>, IProblemSolutionsService
    {

        private readonly ILogger _logger;
        private readonly IProblemSolutionsRepository _problemSolutionRepository;

        public ProblemSolutionsManager(IProblemSolutionsRepository problemSolutionRepository, ILogger<ProblemSolutions> logger)
        {
            _logger = logger;
            _problemSolutionRepository = problemSolutionRepository;
        }
        public async Task<ProblemSolutions> AddAsync(ProblemSolutions problemSolution)
        {
            // TODO:: Searching without Id 
            _logger.LogInformation($"AddProblemSolutionsAsync method started with @problemSolution={problemSolution}");
            var isExist = await _problemSolutionRepository.GetAsync(x => x.Id.Equals(problemSolution.Id));
            if (isExist != null)
            {
                throw new InternalException(Messages.DublicatedId);
            }
            var addedProblemSolution = await _problemSolutionRepository.AddAsync(problemSolution);
            _logger.LogInformation($"AddProblemSolutionsAsync method finished with @addedProblemSolution={addedProblemSolution}");
            return addedProblemSolution;
        }

        public async Task<ProblemSolutions> DeleteAsync(ProblemSolutions problemSolution)
        {
            // TODO:: Searching without Id
            _logger.LogInformation($"DeleteProblemSolutionsAsync method started with @problemSolution={problemSolution}");
            var isExist = await _problemSolutionRepository.GetAsync(x => x.Id.Equals(problemSolution.Id));
            if (isExist == null)
            {
                throw new InternalException(Messages.NotExist);
            }
            await _problemSolutionRepository.DeleteAsync(problemSolution);
            _logger.LogInformation($"DeleteProblemSolutionsAsync method finished with @deletedProblemSolution={problemSolution}");
            return problemSolution;
        }

        public async Task<List<ProblemSolutions>> GetListAsync(Expression<Func<ProblemSolutions, bool>>? predicate)
        {
            _logger.LogInformation($"GetListProblemSolutionsAsync method started with @predicate={predicate}");
            var list = await _problemSolutionRepository.GetListAysnc(predicate);
            _logger.LogInformation($"GetListProblemSolutionsAsync method finished with @list={list}");
            return list.ToList();
        }

        public async Task<ProblemSolutions> UpdateAsync(ProblemSolutions problemSolution)
        {
            _logger.LogInformation($"UpdateProblemSolutionsAsync method started with @problemSolution={problemSolution}");
            var isExist = await _problemSolutionRepository.GetAsync(x => x.Id.Equals(problemSolution.Id));
            if (isExist == null)
            {
                throw new InternalException(Messages.NotExist);
            }
            isExist.UserSolutionId = problemSolution.UserSolutionId;
            isExist.ProblemId = problemSolution.ProblemId;
            var updatedProblemSolution = await _problemSolutionRepository.UpdateAsync(isExist);
            _logger.LogInformation($"UpdateProblemSolutionsAsync method finished with @updatedProblemSolution={updatedProblemSolution}");
            return updatedProblemSolution;
        }
    }
}
