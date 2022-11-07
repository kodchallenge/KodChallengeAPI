using Kod.Application.Abstractions.Services;
using Kod.Domain.Models;
using MediatR;

namespace Kod.Application.Modules.CategoriModules.Commands
{
    public record UpdateCategoriesCommand(string Name, string Slug, DateTime CreatedAt) : IRequest<UpdateCategoriesCommandResponse>;

    public record UpdateCategoriesCommandResponse(int id);

    public record UpdateCategoriesCommandHandler : IRequestHandler<UpdateCategoriesCommand, UpdateCategoriesCommandResponse>
    {
        private readonly ICategoriesService _categoriService;

        public UpdateCategoriesCommandHandler(ICategoriesService categoriService)
        {
            _categoriService = categoriService;
        }
        public async Task<UpdateCategoriesCommandResponse> Handle(UpdateCategoriesCommand request, CancellationToken cancellationToken)
        {
            Categories addCategories = new(request.Name, request.Slug, request.CreatedAt);
            var categories = await _categoriService.UpdateAsync(addCategories);

            return new UpdateCategoriesCommandResponse(categories.Id);
        }
    }
}
