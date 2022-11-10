using Kod.Domain.Models;
using System.Linq.Expressions;

namespace Kod.Application.Abstractions.Services
{
    public interface ICategoriesService : IBaseService<Categories>
    {
        Task<Categories> AddAsync(Categories categori);  
        Task<List<Categories>> GetListAsync(Expression<Func<Categories, bool>>? predicate); 

        Task<Categories> UpdateAsync(Categories categori);

        Task<Categories> DeleteAsync(Categories categori);
        Task<Categories> DeleteByIdAsync(int Id);
    }
}
