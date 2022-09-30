using Kod.Application.Modules.CategoriesModules.Queries;
using Kod.Application.Modules.ProgrammingLang.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Kod.WebAPI.Controllers
{
    public class CategoriesController : ApiControllerBase 
    {
        private readonly ILogger _logger;

        public CategoriesController(ILogger<CategoriesController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllCategories()
        {
            var list = await Mediator.Send(new GetAllProgrammingLanguagesQuery());
            var response = list.ConvertAll(x => new GetAllCategoriesQueryResponse(x.Id, x.Name, x.Slug));

            return Ok(response, "listed");
        }
    }
}
