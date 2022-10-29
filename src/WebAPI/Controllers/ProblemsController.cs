using Kod.Domain.Models;

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
