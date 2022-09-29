using Kod.Core.Domain.Models;

namespace Kod.WebAPI.Requests.Defaults
{
    public record DefaultPaginateRequest(int pageSize, int pageIndex)
    {
        public PaginateRequest ToCorePaginateRequest()
        {
            return new PaginateRequest(pageIndex, pageSize);
        }
    }
}
