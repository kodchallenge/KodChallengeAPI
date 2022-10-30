using Kod.Application.Abstractions.Repositories;
using Kod.Application.Abstractions.Services;
using Kod.Core.Exceptions;
using Kod.Domain.Models;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;
using Kod.Application.Constants.Messages;

namespace Kod.Application.Managers
{
    public class ProgrammingLanguagesManager : BaseManager<ProgrammingLanguages>, IProgrammingLanguagesService
    {
        private readonly ILogger _logger;
        private readonly IProgrammingLanguagesRepository _programmingLanguageRepository;

        public ProgrammingLanguagesManager(ILogger<ProgrammingLanguagesManager> logger, IProgrammingLanguagesRepository programmingLanguageRepository)
        {
            _logger = logger;
            _programmingLanguageRepository = programmingLanguageRepository;
        }

        public async Task<ProgrammingLanguages> AddAsync(ProgrammingLanguages lang)
        {
            _logger.LogInformation($"AddProgrammingLanguageAsync method started with @lang={lang}");
            
            // Example business logic
            var isExistsName = await _programmingLanguageRepository.GetAsync(x => x.Name.Equals(lang.Name));
            if(isExistsName != null)
            {
                throw new InternalException(Messages.DublicatedName);
            }

            var addedProgrammingLanguage = await _programmingLanguageRepository.AddAsync(lang);

            _logger.LogInformation($"AddProgrammingLanguageAsync method finished with @addedProgrammingLanguage={addedProgrammingLanguage}");
            return addedProgrammingLanguage;
        }

        public Task<ProgrammingLanguages> DeleteAsync(ProgrammingLanguages programmingLanguage)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProgrammingLanguages>> GetListAsync(Expression<Func<ProgrammingLanguages, bool>>? predicate)
        {
            _logger.LogInformation($"GetProgrammingLanguageListAsync method started with @predicate={predicate}");

            var list = await _programmingLanguageRepository.GetListAysnc(predicate);

            _logger.LogInformation($"GetProgrammingLanguageListAsync method finished with @list={list}");

            return list.ToList();
        }

        public Task<ProgrammingLanguages> UpdateAsync(ProgrammingLanguages programmingLanguage)
        {
            throw new NotImplementedException();
        }
    }
}
