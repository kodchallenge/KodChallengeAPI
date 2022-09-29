
using AutoMapper;
using Kod.Application.Abstractions.Services;
using Kod.Application.Modules.ProgrammingLang.Queries;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Kod.Application.Modules.CategoriesModules.Queries
{
    public record GetAllCategoriQuery() : IRequest<List<GetAllCategoriesQueryResponse>>;

    public record GetAllCategoriesQueryResponse(int Id, string Name, string Slug);

    public record GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriQuery, List<GetAllCategoriesQueryResponse>>
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly ICategoriService _categoriService;
        public GetAllCategoriesQueryHandler(ILogger<GetAllCategoriesQueryHandler> logger, IMapper mapper, ICategoriService categoriService)
        {
            _logger = logger;
            _mapper = mapper;
            _categoriService = categoriService;
        }

        public async Task<List<GetAllCategoriesQueryResponse>> Handle(GetAllCategoriQuery request, CancellationToken cancellationToken)
        {
            var categories = await _categoriService.GetListAsync(null);

            return categories.ConvertAll(x => _mapper.Map<GetAllCategoriesQueryResponse>(x));
        }
    }
}
