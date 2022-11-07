using Kod.Application.Abstractions.Services;
using Kod.Domain.Models;
using MediatR;

namespace Kod.Application.Modules.CategoriModules.Commands.AddCategories
{
    public record AddCategoriesCommand(string Name, string Slug, DateTime CreatedAt) : IRequest<AddCategoriesCommandResponse>;

    public record AddCategoriesCommandResponse(int id);

    public record AddCategoriesCommandHandler : IRequestHandler<AddCategoriesCommand, AddCategoriesCommandResponse>
    {
        private readonly ICategoriesService _categoriService;

        public AddCategoriesCommandHandler(ICategoriesService categoriService)
        {
            _categoriService = categoriService;
        }
        public async Task<AddCategoriesCommandResponse> Handle(AddCategoriesCommand request, CancellationToken cancellationToken)
        {
            Categories addCategories = new(request.Name, request.Slug, request.CreatedAt);
            var categories = await _categoriService.AddAsync(addCategories);

            return new AddCategoriesCommandResponse(categories.Id);
        }
    }
}
