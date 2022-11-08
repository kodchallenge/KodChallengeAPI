using Kod.Application.Modules.ProblemModules.Commands;
using Kod.Application.Modules.ProblemModules.Queries;
using Kod.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kod.WebAPI.Controllers
{
    public class ProblemsController : ApiControllerBase
    {
        private readonly ILogger _logger;

        public ProblemsController(ILogger<Problems> logger)
        {
            _logger = logger;   
        }

        [HttpPost("")]
        public async Task<IActionResult> AddProblems(Problems problems)
        {
            var addedProblems = await Mediator.Send(new AddProblemCommand(problems.CategoriId, problems.Title, problems.Description, problems.IsPrivate, problems.Point, problems.CreatedAt));
            return Ok(addedProblems, "added");
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllProblems()
        {
            var list = await Mediator.Send(new GetAllProblemsQuery());
            var response = list.ConvertAll(x => new GetAllProblemsQueryResponse(x.Id, x.CategoriId, x.Title, x.Description, x.IsPrivate, x.Point, x.CreatedAt));

            return Ok(response, "listed");
        }
    }
}
