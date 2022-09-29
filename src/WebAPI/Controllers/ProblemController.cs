using Kod.Application.Modules.ProgrammingLang.Queries;
using Kod.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kod.WebAPI.Controllers
{
    public class ProblemController : ApiControllerBase
    {
        private readonly ILogger _logger;

        public ProblemController(ILogger<Problem> logger)
        {
            _logger = logger;   
        }
    }
}
