using Kod.Core.Domain.Models;
using Kod.Domain.Models;
using System.Linq.Expressions;

namespace Kod.Application.Abstractions.Services
{
    public interface ICategoriService : IBaseService<Categori>
    {
        Task<Categori> AddAsync(Categori categori);  
        Task<List<Categori>> GetListAsync(Expression<Func<Categori, bool>>? predicate); 
    }
}
