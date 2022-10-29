using Kod.Domain.Models;

namespace Kod.WebAPI.Controllers
{
    public class UserSolutionsController : ApiControllerBase
    {
        private readonly ILogger _logger;

        public UserSolutionsController(ILogger<Problems> logger)
        {
            _logger = logger;
        }
    }
}
