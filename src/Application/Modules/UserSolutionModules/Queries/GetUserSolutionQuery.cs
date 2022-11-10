using AutoMapper;
using Kod.Application.Abstractions.Services;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Modules.UserSolutionModules.Queries
{
    public record GetUserSolutionQueryResponse(int UserId, string SolutionPath, int Score, DateTime CreatedAt);

    public record GetUserSolutionQuery(int Id) : IRequest<List<GetUserSolutionQueryResponse>>;

    public record GetUserSolutionQueryHandler : IRequestHandler<GetUserSolutionQuery, List<GetUserSolutionQueryResponse>>
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly IUserSolutionsService _userSolutionsService;
        public GetUserSolutionQueryHandler(ILogger<GetUserSolutionQueryHandler> logger, IMapper mapper, IUserSolutionsService userSolutionsService)
        {
            _logger = logger;
            _mapper = mapper;
            _userSolutionsService = userSolutionsService;
        }

        public async Task<List<GetUserSolutionQueryResponse>> Handle(GetUserSolutionQuery request, CancellationToken cancellationToken)
        {
            var solutions = await _userSolutionsService.GetByIdAsync(request.Id);
            List<GetUserSolutionQueryResponse> problems = new List<GetUserSolutionQueryResponse>();
            problems.Add(new GetUserSolutionQueryResponse(solutions.UserId, solutions.SolutionPath, solutions.Score, solutions.CreatedAt));
            return problems;
        }
    }
}
