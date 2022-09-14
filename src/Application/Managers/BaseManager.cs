using Kod.Application.Abstractions.Services;
using Kod.Core.Domain.Abstractions;

namespace Kod.Application.Managers
{
    public abstract class BaseManager<T> : IBaseService<T> where T: IEntity
    {

    }
}
