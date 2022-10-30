using Kod.Domain.Models;
using System.Linq.Expressions;

namespace Kod.Application.Abstractions.Services
{
    public interface IProgrammingLanguagesService : IBaseService<ProgrammingLanguages>
    {
        Task<ProgrammingLanguages> AddAsync(ProgrammingLanguages programmingLanguage);
        Task<List<ProgrammingLanguages>> GetListAsync(Expression<Func<ProgrammingLanguages, bool>>? predicate);

        Task<ProgrammingLanguages> UpdateAsync(ProgrammingLanguages programmingLanguage);

        Task<ProgrammingLanguages> DeleteAsync(ProgrammingLanguages programmingLanguage);
    }
}
