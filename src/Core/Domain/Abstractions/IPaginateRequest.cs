
namespace Kod.Core.Domain.Abstractions
{
    public interface IPaginateRequest
    {
        int PageNum { get; }
        int PageSize { get; }
    }
}
