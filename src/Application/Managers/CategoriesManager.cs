using Kod.Application.Abstractions.Repositories;
using Kod.Application.Abstractions.Services;
using Kod.Application.Constants.Messages;
using Kod.Core.Exceptions;
using Kod.Domain.Models;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace Kod.Application.Managers
{
    public class CategoriesManager : BaseManager<Categories>, ICategoriesService
    {
        private readonly ILogger _logger;
        private readonly ICategoriesRepository _categoriesRepository;

        public CategoriesManager(ILogger<CategoriesManager> logger, ICategoriesRepository categoriesRepository)
        {
            _logger = logger;
            _categoriesRepository = categoriesRepository;
        }
    
        public async Task<Categories> AddAsync(Categories categori)
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

        public Task<Categories> DeleteAsync(Categories categori)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Categories>> GetListAsync(Expression<Func<Categories, bool>>? predicate)
        {
            _logger.LogInformation($"GetCategoriListAsync method started with @predicate={predicate}");

            var list = await _categoriesRepository.GetListAysnc(predicate);

            _logger.LogInformation($"GetCategoriListAsync method finished with @list={list}");

            return list.ToList();
        }

        public async Task<Categories> UpdateAsync(Categories categori)
        {
            _logger.LogInformation($"UpdateCategoriesAsync method started with @categori={categori}");
            var isExistsName = await _categoriesRepository.GetAsync(x => x.Id.Equals(categori.Id));
            if (isExistsName != null)
            {
                throw new InternalException(Messages.DublicatedName);
            }
            // ToDo: check this function
            isExistsName.Name = categori.Name;
            isExistsName.Slug = categori.Slug;

            var updatedCategori = await _categoriesRepository.UpdateAsync(isExistsName);

            _logger.LogInformation($"AddCategoriAsync method finished with @addedCategori={updatedCategori}");
            return updatedCategori;
        }
    }
}
