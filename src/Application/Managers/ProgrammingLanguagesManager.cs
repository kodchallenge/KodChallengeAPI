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

        public async Task<ProgrammingLanguages> AddAsync(ProgrammingLanguages programmingLanguage)
        {
            _logger.LogInformation($"AddProgrammingLanguagesAsync method started with @programmingLanguage={programmingLanguage}");
            
            // Example business logic
            var isExistsName = await _programmingLanguageRepository.GetAsync(x => x.Name.Equals(programmingLanguage.Name));
            if(isExistsName != null)
            {
                throw new InternalException(Messages.DublicatedName);
            }

            var addedProgrammingLanguage = await _programmingLanguageRepository.AddAsync(programmingLanguage);

            _logger.LogInformation($"AddProgrammingLanguagesAsync method finished with @addedProgrammingLanguage={addedProgrammingLanguage}");
            return addedProgrammingLanguage;
        }

        public async Task<ProgrammingLanguages> DeleteAsync(ProgrammingLanguages programmingLanguage)
        {
            _logger.LogInformation($"DeleteProgrammingLanguagesAsync method started with @programmingLanguage={programmingLanguage}");
            var isExist = await _programmingLanguageRepository.GetAsync(x => x.Name.Equals(programmingLanguage.Name));
            if (isExist == null)
            {
                throw new InternalException(Messages.NotExist);
            }
            await _programmingLanguageRepository.DeleteAsync(programmingLanguage);
            _logger.LogInformation($"DeleteProgrammingLanguagesAsync method finished with @deletedProgrammingLanguage={programmingLanguage}");
            return programmingLanguage;
        }

        public async Task<List<ProgrammingLanguages>> GetListAsync(Expression<Func<ProgrammingLanguages, bool>>? predicate)
        {
            _logger.LogInformation($"GetProgrammingLanguagesListAsync method started with @predicate={predicate}");

            var list = await _programmingLanguageRepository.GetListAysnc(predicate);

            _logger.LogInformation($"GetProgrammingLanguagesListAsync method finished with @list={list}");

            return list.ToList();
        }

        public async Task<ProgrammingLanguages> UpdateAsync(ProgrammingLanguages programmingLanguage)
        {
            _logger.LogInformation($"UpdateProgrammingLanguagesAsync method started with @programmingLanguage={programmingLanguage}");
            var isExist = await _programmingLanguageRepository.GetAsync(x => x.Id.Equals(programmingLanguage.Id));
            if (isExist == null)
            {
                throw new InternalException(Messages.NotExist);
            }
            isExist.Name = programmingLanguage.Name;
            isExist.Slug = programmingLanguage.Slug;
            var updatedProgrammingLanguage = await _programmingLanguageRepository.UpdateAsync(isExist);
            _logger.LogInformation($"UpdateProgrammingLanguagesAsync method finished with @updatedProgrammingLanguage={updatedProgrammingLanguage}");
            return updatedProgrammingLanguage;
        }
    }
}
