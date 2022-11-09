using Application.Modules.UserSolutionModules.Commands;
using Application.Modules.UserSolutionModules.Queries;
using Kod.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kod.WebAPI.Controllers
{
    public class UserSolutionsController : ApiControllerBase
    {
        private readonly ILogger _logger;

        public UserSolutionsController(ILogger<Problems> logger)
        {
            _logger = logger;
        }

        [HttpPost("")]
        public async Task<IActionResult> AddUserSolution(UserSolutions userSolutions)
        {
            var addedProblems = await Mediator.Send(new AddUserSolutionCommand(userSolutions.UserId, userSolutions.SolutionPath, userSolutions.Score, userSolutions.CreatedAt));
            return Ok(addedProblems, "added");
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllUserSolutions()
        {
            var list = await Mediator.Send(new GetAllUserSolutionsQuery());
            var response = list.ConvertAll(x => new GetAllUserSolutionsQueryResponse(x.Id, x.UserId, x.SolutionPath, x.Score, x.CreatedAt));

            return Ok(response, "listed");
        }
    }
}
