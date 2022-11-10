using Kod.Application.Modules.CategoriesModules.Queries;
using Kod.Application.Modules.CategoriModules.Commands;
using Kod.WebAPI.Responses.CategoriResponses;
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
            var list = await Mediator.Send(new GetAllCategoriesQuery());
            var response = list.ConvertAll(x => new GetAllCategoriesResponse(x.Id, x.Name, x.Slug, x.CreatedAt));

            return Ok(response, "listed");
        }

        [HttpPost("")]
        public async Task<IActionResult> AddCategories(Categories categories)
        {
            var addedCategories = await Mediator.Send(new AddCategoriesCommand(categories.Name,categories.Slug, categories.CreatedAt));
            return Ok(addedCategories, "added");
        }

        //[HttpPut("")]
        //public async Task<IActionResult> UpdateCategories(Categories categories)
        //{
        //    var updatedCategories = await Mediator.Send(new UpdateCategoriesCommand(categories.Name, categories.Slug, categories.CreatedAt));
        //    return Ok(updatedCategories, "updated");
        //}

        [HttpDelete("/{Id}")]

        public async Task<IActionResult> DeleteCategoriById(int Id)
        {
            var deleteCategori = await Mediator.Send(new DeleteCategoriCommand(Id));

            return Ok(deleteCategori, "deleted");
        }

    }
}
