using Kod.Core.Domain.Abstractions;
using Kod.Core.Domain.Models;
using System.Linq.Expressions;

namespace Kod.Core.Abstractions.Database
{
    public interface IBaseRepository<T>
    {
        IList<T> GetList(Expression<Func<T, bool>>? predicate=null);
        Paginate<T> GetListWithPaginate(Expression<Func<T, bool>>? predicate, IPaginateRequest paginateRequest, Func<T, object> orderby);
        T? Get(Expression<Func<T, bool>> predicate);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}
