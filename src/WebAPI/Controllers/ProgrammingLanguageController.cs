using Kod.Application.Modules.ProgrammingLang.Queries;
using Kod.WebAPI.Responses.ProgrammingLand;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kod.WebAPI.Controllers
{
    public class ProgrammingLanguageController : ApiControllerBase
    {
        private readonly ILogger _logger;

        public ProgrammingLanguageController(ILogger<ProgrammingLanguageController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllLanguages()
        {
            var list = await Mediator.Send(new GetAllProgrammingLanguagesQuery());
            var response = list.ConvertAll(x => new GetAllProgrammingLanguageResponse(x.Id, x.Name, x.Slug));
            
            return Ok(response, "listed");
        }
    }
}
