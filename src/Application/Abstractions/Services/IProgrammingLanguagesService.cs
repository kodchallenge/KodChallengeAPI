using Kod.Domain.Models;
using System.Linq.Expressions;

namespace Kod.Application.Abstractions.Services
{
    public interface IProgrammingLanguagesService : IBaseService<ProgrammingLanguages>
    {
        Task<ProgrammingLanguages> AddAsync(ProgrammingLanguages lang);
        Task<List<ProgrammingLanguages>> GetListAsync(Expression<Func<ProgrammingLanguages, bool>>? predicate);
    }
}
