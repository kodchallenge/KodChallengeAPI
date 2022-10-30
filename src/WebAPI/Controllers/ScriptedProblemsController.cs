using Kod.Domain.Models;

namespace Kod.WebAPI.Controllers
{
    public class ScriptedProblemsController : ApiControllerBase
    {
        private readonly ILogger _logger;

        public ScriptedProblemsController(ILogger<Problems> logger)
        {
            _logger = logger;
        }
    }
}
