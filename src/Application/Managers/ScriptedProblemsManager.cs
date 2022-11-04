using Kod.Application.Abstractions.Repositories;
using Kod.Application.Abstractions.Services;
using Kod.Application.Constants.Messages;
using Kod.Core.Exceptions;
using Kod.Domain.Models;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace Kod.Application.Managers
{
    public class ScriptedProblemsManager : BaseManager<ScriptedProblems>, IScriptedProblemsService
    {
        private readonly ILogger _logger;
        private readonly IScriptedProblemsRepository _scriptedProblemsRepository;

        public ScriptedProblemsManager(IScriptedProblemsRepository scriptedProblemsRepository, ILogger<Problems> logger)
        {
            _logger = logger;
            _scriptedProblemsRepository = scriptedProblemsRepository;
        }
        public async Task<ScriptedProblems> AddAsync(ScriptedProblems scriptedProblem)
        {
            _logger.LogInformation($"AddScriptedProblemsAsync method started with @scriptedProblem={scriptedProblem}");

            // Example business logic
            var isExistsName = await _scriptedProblemsRepository.GetAsync(x => x.Id.Equals(scriptedProblem.Id));
            if (isExistsName != null)
            {
                throw new InternalException(Messages.DublicatedId);
            }

            var addedScriptedProblem = await _scriptedProblemsRepository.AddAsync(scriptedProblem);

            _logger.LogInformation($"AddScriptedProblemsAsync method finished with @addedScriptedProblem={addedScriptedProblem}");
            return addedScriptedProblem;
        }

        public async Task<ScriptedProblems> DeleteAsync(ScriptedProblems scriptedProblem)
        {
            _logger.LogInformation($"DeleteScriptedProblemsAsync method started with @scriptedProblem={scriptedProblem}");
            var isExist = await _scriptedProblemsRepository.GetAsync(x => x.Id.Equals(scriptedProblem.Id));
            if (isExist == null)
            {
                throw new InternalException(Messages.NotExist);
            }
            await _scriptedProblemsRepository.DeleteAsync(scriptedProblem);
            _logger.LogInformation($"DeleteScriptedProblemsAsync method finished with @deletedScriptedProblem={scriptedProblem}");
            return scriptedProblem;
        }

        public async Task<List<ScriptedProblems>> GetListAsync(Expression<Func<ScriptedProblems, bool>>? predicate)
        {
            _logger.LogInformation($"GetScriptedProblemsListAsync method started with @predicate={predicate}");

            var list = await _scriptedProblemsRepository.GetListAysnc(predicate);

            _logger.LogInformation($"GetScriptedProblemsListAsync method finished with @list={list}");

            return list.ToList();
        }

        public async Task<ScriptedProblems> UpdateAsync(ScriptedProblems scriptedProblem)
        {
            _logger.LogInformation($"UpdateScriptedProblemsAsync method started with @scriptedProblem={scriptedProblem}");
            var isExist = await _scriptedProblemsRepository.GetAsync(x => x.Id.Equals(scriptedProblem.Id));
            if (isExist == null)
            {
                throw new InternalException(Messages.NotExist);
            }
            isExist.ProblemId = scriptedProblem.ProblemId;
            isExist.LanguageId = scriptedProblem.LanguageId;
            var updatedScriptedProblem = await _scriptedProblemsRepository.UpdateAsync(isExist);
            _logger.LogInformation($"UpdateScriptedProblemsAsync method finished with @updatedScriptedProblem={updatedScriptedProblem}");
            return updatedScriptedProblem;
        }
    }
}
