using AutoMapper;
using Kod.Application.Abstractions.Services;
using Kod.Core.Domain.Models;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Kod.Application.Modules.ProgrammingLang.Queries
{
    public record GetAllProgrammingLanguagesQuery() : IRequest<List<GetAllProgrammingLanguagesQueryResponse>>;

    public record GetAllProgrammingLanguagesQueryResponse(int Id, string Name, string Slug);

    public record GetAllProgrammingLanguagesQueryHandler : IRequestHandler<GetAllProgrammingLanguagesQuery, List<GetAllProgrammingLanguagesQueryResponse>>
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly IProgrammingLanguageService _programmingLanguageService;
        public GetAllProgrammingLanguagesQueryHandler(ILogger<GetAllProgrammingLanguagesQueryHandler> logger, IMapper mapper, IProgrammingLanguageService programmingLanguageService)
        {
            _logger = logger;
            _mapper = mapper;
            _programmingLanguageService = programmingLanguageService;
        }

        public async Task<List<GetAllProgrammingLanguagesQueryResponse>> Handle(GetAllProgrammingLanguagesQuery request, CancellationToken cancellationToken)
        {
            var programmingLanguages = await _programmingLanguageService.GetListAsync(null);

            return programmingLanguages.ConvertAll(x => _mapper.Map<GetAllProgrammingLanguagesQueryResponse>(x));
        }
    }
}
