using AutoMapper;
using Kod.Application.Abstractions.Services;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Kod.Application.Modules.ProblemModules.Queries
{
    public record GetProblemQueryResponse(int CategoriId, string Title, string Description, bool IsPrivate, int Point, DateTime CreatedAt);

    public record GetProblemQuery(int Id) : IRequest<List<GetProblemQueryResponse>>;

    public record GetProblemQueryHandler : IRequestHandler<GetProblemQuery, List<GetProblemQueryResponse>>
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly IProblemsService _problemsService;
        public GetProblemQueryHandler(ILogger<GetProblemQueryHandler> logger, IMapper mapper, IProblemsService problemsService)
        {
            _logger = logger;
            _mapper = mapper;
            _problemsService = problemsService;
        }

        public async Task<List<GetProblemQueryResponse>> Handle(GetProblemQuery request, CancellationToken cancellationToken)
        {
            var problem = await _problemsService.GetByIdAsync(request.Id);
            List<GetProblemQueryResponse> problems = new List<GetProblemQueryResponse>();
            problems.Add(new GetProblemQueryResponse(problem.CategoriId, problem.Title, problem.Description, problem.IsPrivate, problem.Point, problem.CreatedAt));
            return problems;
        }
    }
}
