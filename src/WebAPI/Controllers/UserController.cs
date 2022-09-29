
using Kod.Application.Modules.UserModules.Queries;
using Kod.WebAPI.Requests.Defaults;
using Kod.WebAPI.Responses.UserResponses.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Kod.WebAPI.Controllers
{
    public class UserController : ApiControllerBase
    {
        [HttpGet("")]
        public async Task<IActionResult> GetUsersList([FromQuery] DefaultPaginateRequest paginateRequest) 
        {
            var list = await Mediator.Send(new GetAllUsersQuery(paginateRequest.ToCorePaginateRequest()));

            var response = list.ConvertItems(x => GetAllUsersResponse.From(x));
            return Ok(list);
        }
    }
}
