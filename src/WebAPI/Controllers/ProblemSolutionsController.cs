using Kod.Domain.Models;

namespace Kod.WebAPI.Controllers
{
    public class ProblemSolutionsController : ApiControllerBase
    {
        private readonly ILogger _logger;

        public ProblemSolutionsController(ILogger<Problems> logger)
        {
            _logger = logger;
        }
    }
}
