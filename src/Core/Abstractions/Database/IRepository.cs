
namespace Kod.Core.Abstractions.Database
{
    public interface IRepository<T> : IAsyncRepository<T>, IBaseRepository<T>
    {
    }
}
