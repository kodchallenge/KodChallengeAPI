using Kod.Application.Modules.CategoriesModules.Queries;
using Kod.Application.Modules.CategoriModules.Commands.AddCategories;
using Kod.Application.Modules.CategoriModules.Commands.UpdateCategories;
using Kod.Application.Modules.ProgrammingLang.Queries;
using Kod.Domain.Models;
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

        [HttpPost("")]
        public async Task<IActionResult> AddCategories(Categories categories)
        {
            var addedCategories = await Mediator.Send(new AddCategoriesCommand(categories.Name,categories.Slug));
            return Ok(addedCategories, "added");
        }

        [HttpPut("")]
        public async Task<IActionResult> UpdateCategories(Categories categories)
        {
            var updatedCategories = await Mediator.Send(new UpdateCategoriesCommand(categories.Name, categories.Slug));
            return Ok(updatedCategories, "updated");
        }
    }
}
