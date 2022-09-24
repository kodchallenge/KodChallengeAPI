using Kod.Application.Modules.UserModules.Queries;

namespace Kod.WebAPI.Responses.UserResponses.Queries
{
    public record GetAllUsersResponse (int id, string fullname, string username)
    {
        public static GetAllUsersResponse From(GetAllUsersQueryResponse res)
        {
            return new GetAllUsersResponse(res.Id, res.FullName, res.Username);
        }
    }
}
