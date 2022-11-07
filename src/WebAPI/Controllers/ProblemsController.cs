using Kod.Application.Modules.ProblemModules.Commands;
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
            return Ok(AddProblems, "added");
        }
    }
}
