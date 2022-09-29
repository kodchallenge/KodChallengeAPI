using Kod.Core.Domain.Abstractions;

namespace Kod.Core.Domain.Models
{
    public record PaginateRequest(int PageNum, int PageSize) : IPaginateRequest;
}