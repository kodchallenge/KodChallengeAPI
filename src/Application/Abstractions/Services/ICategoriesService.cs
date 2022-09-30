using Kod.Core.Domain.Models;
using Kod.Domain.Models;
using System.Linq.Expressions;

namespace Kod.Application.Abstractions.Services
{
    public interface ICategoriesService : IBaseService<Categories>
    {
        Task<Categories> AddAsync(Categories categori);  
        Task<List<Categories>> GetListAsync(Expression<Func<Categories, bool>>? predicate); 
    }
}
