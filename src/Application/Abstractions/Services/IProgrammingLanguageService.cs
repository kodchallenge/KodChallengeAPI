using Kod.Core.Domain.Models;
using Kod.Domain.Models;
using System.Linq.Expressions;

namespace Kod.Application.Abstractions.Services
{
    public interface IProgrammingLanguageService : IBaseService<ProgrammingLanguage>
    {
        Task<ProgrammingLanguage> AddAsync(ProgrammingLanguage lang);
        Task<List<ProgrammingLanguage>> GetListAsync(Expression<Func<ProgrammingLanguage, bool>>? predicate);
    }
}
