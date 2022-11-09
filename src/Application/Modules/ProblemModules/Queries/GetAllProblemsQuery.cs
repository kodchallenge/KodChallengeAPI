using AutoMapper;
using Kod.Application.Abstractions.Services;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Kod.Application.Modules.ProblemModules.Queries
{
    public record GetAllProblemsQueryResponse(int Id, int CategoriId, string Title, string Description, bool IsPrivate, int Point, DateTime CreatedAt);

    public record GetAllProblemsQuery() : IRequest<List<GetAllProblemsQueryResponse>>;

    public record GetAllProblemsQueryHandler : IRequestHandler<GetAllProblemsQuery, List<GetAllProblemsQueryResponse>>
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly IProblemsService _problemsService;
        public GetAllProblemsQueryHandler(ILogger<GetAllProblemsQueryHandler> logger, IMapper mapper, IProblemsService problemsService)
        {
            _logger = logger;
            _mapper = mapper;
            _problemsService = problemsService;
        }

        public async Task<List<GetAllProblemsQueryResponse>> Handle(GetAllProblemsQuery request, CancellationToken cancellationToken)
        {
            var problems = await _problemsService.GetListAsync(null);
            return problems.ConvertAll(x => _mapper.Map<GetAllProblemsQueryResponse>(x));
        }
    }
}
