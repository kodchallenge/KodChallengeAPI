using Kod.Application.Modules.ProgrammingLang.Queries;
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
    }
}
