
using AutoMapper;
using Kod.Application.Abstractions.Services;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Kod.Application.Modules.CategoriesModules.Queries
{
    public record GetAllCategoriesQuery() : IRequest<List<GetAllCategoriesQueryResponse>>;

    public record GetAllCategoriesQueryResponse(DateTime CreatedAt, int Id, string Name, string Slug);

    public record GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, List<GetAllCategoriesQueryResponse>>
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly ICategoriesService _categoriService;
        public GetAllCategoriesQueryHandler(ILogger<GetAllCategoriesQueryHandler> logger, IMapper mapper, ICategoriesService categoriService)
        {
            _logger = logger;
            _mapper = mapper;
            _categoriService = categoriService;
        }

        public async Task<List<GetAllCategoriesQueryResponse>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categories = await _categoriService.GetListAsync(null);

            return categories.ConvertAll(x => _mapper.Map<GetAllCategoriesQueryResponse>(x));
        }
    }
}
