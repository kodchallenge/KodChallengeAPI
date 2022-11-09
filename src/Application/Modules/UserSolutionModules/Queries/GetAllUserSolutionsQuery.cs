using AutoMapper;
using Kod.Application.Abstractions.Services;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Modules.UserSolutionModules.Queries
{
    public record GetAllUserSolutionsQueryResponse(int Id, int UserId, string SolutionPath, int Score, DateTime CreatedAt);

    public record GetAllUserSolutionsQuery() : IRequest<List<GetAllUserSolutionsQueryResponse>>;

    public record GetAllUserSolutionsQueryHandler : IRequestHandler<GetAllUserSolutionsQuery, List<GetAllUserSolutionsQueryResponse>>
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly IUserSolutionsService _userSolutionsService;
        public GetAllUserSolutionsQueryHandler(ILogger<GetAllUserSolutionsQueryHandler> logger, IMapper mapper, IUserSolutionsService userSolutionsService)
        {
            _logger = logger;
            _mapper = mapper;
            _userSolutionsService = userSolutionsService;
        }

        public async Task<List<GetAllUserSolutionsQueryResponse>> Handle(GetAllUserSolutionsQuery request, CancellationToken cancellationToken)
        {
            var problmes = await _userSolutionsService.GetListAsync(null);
            return problmes.ConvertAll(x => _mapper.Map<GetAllUserSolutionsQueryResponse>(x));
        }
    }
}
