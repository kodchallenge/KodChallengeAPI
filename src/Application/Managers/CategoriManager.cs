using Kod.Application.Abstractions.Repositories;
using Kod.Application.Abstractions.Services;
using Kod.Application.Constants.Messages;
using Kod.Core.Exceptions;
using Kod.Domain.Models;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace Kod.Application.Managers
{
    public class CategoriManager : BaseManager<Categori>, ICategoriService
    {
        private readonly ILogger _logger;
        private readonly ICategoriRepository _categoriesRepository;

        public CategoriManager(ILogger<CategoriManager> logger, ICategoriRepository categoriesRepository)
        {
            _logger = logger;
            _categoriesRepository = categoriesRepository;
        }
    
        public async Task<Categori> AddAsync(Categori categori)
        {
            _logger.LogInformation($"AddCategoriesAsync method started with @categori={categori}");
            var isExistsName = await _categoriesRepository.GetAsync(x => x.Name.Equals(categori.Name));
            if (isExistsName != null)
            {
                throw new InternalException(Messages.DublicatedName);
            }

            var addedCategori = await _categoriesRepository.AddAsync(categori);

            _logger.LogInformation($"AddCategoriAsync method finished with @addedCategori={addedCategori}");
            return addedCategori;
        }

        public async Task<List<Categori>> GetListAsync(Expression<Func<Categori, bool>>? predicate)
        {
            _logger.LogInformation($"GetCategoriListAsync method started with @predicate={predicate}");

            var list = await _categoriesRepository.GetListAysnc(predicate);

            _logger.LogInformation($"GetCategoriListAsync method finished with @list={list}");

            return list.ToList();
        }

    }
}
