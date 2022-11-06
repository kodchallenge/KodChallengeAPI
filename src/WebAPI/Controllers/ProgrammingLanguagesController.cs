using Kod.Application.Modules.ProgrammingLang.Queries;
using Kod.WebAPI.Responses.ProgrammingLanguageResponses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kod.WebAPI.Controllers
{
    public class ProgrammingLanguagesController : ApiControllerBase
    {
        private readonly ILogger _logger;

        public ProgrammingLanguagesController(ILogger<ProgrammingLanguagesController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllLanguages()
        {
            var list = await Mediator.Send(new GetAllProgrammingLanguagesQuery());
            var response = list.ConvertAll(x => new GetAllProgrammingLanguageResponse(x.Id, x.Name, x.Slug, x.CreatedAt));
            
            return Ok(response, "listed");
        }
    }
}
