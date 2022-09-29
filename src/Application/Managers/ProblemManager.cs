using Kod.Application.Abstractions.Repositories;
using Kod.Application.Abstractions.Services;
using Kod.Application.Constants.Messages;
using Kod.Core.Exceptions;
using Kod.Domain.Models;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace Kod.Application.Managers
{
    public class ProblemManager : BaseManager<Problem>, IProblemService
    {
        private readonly ILogger _logger;
        private readonly IProblemRepository _problemRepository;

        public ProblemManager(IProblemRepository problemRepository, ILogger<Problem> logger)
        {
            _logger = logger;   
            _problemRepository = problemRepository;
        }

        public async Task<Problem> AddAsync(Problem problem)
        {
            _logger.LogInformation($"AddProblemAsync method started with @lang={problem}");

            // Example business logic
            var isExistsName = await _problemRepository.GetAsync(x => x.Id.Equals(problem.Id));
            if (isExistsName != null)
            {
                throw new InternalException(Messages.DublicatedName);
            }

            var addedProblem = await _problemRepository.AddAsync(problem);

            _logger.LogInformation($"AddProblemAsync method finished with @addedProblem={addedProblem}");
            return addedProblem;
        }

        public async Task<List<Problem>> GetListAsync(Expression<Func<Problem, bool>>? predicate)
        {
            _logger.LogInformation($"GetProblemListAsync method started with @predicate={predicate}");

            var list = await _problemRepository.GetListAysnc(predicate);

            _logger.LogInformation($"GetProblemListAsync method finished with @list={list}");

            return list.ToList();
        }
    }
}
