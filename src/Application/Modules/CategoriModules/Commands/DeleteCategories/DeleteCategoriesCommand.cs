using Kod.Application.Abstractions.Services;
using Kod.Domain.Models;
using MediatR;

namespace Kod.Application.Modules.CategoriModules.Commands
{
    public record DeleteCategoriCommand(int Id) : IRequest<DeleteCategoriCommandResponse>;
    public record DeleteCategoriCommandResponse(int id);

    public record DeleteCategoriCommandHandler : IRequestHandler<DeleteCategoriCommand, DeleteCategoriCommandResponse>
    {
        private readonly ICategoriesService _categoriService;

        public DeleteCategoriCommandHandler(ICategoriesService categoriService)
        {
            _categoriService = categoriService;
        }
        public async Task<DeleteCategoriCommandResponse> Handle(DeleteCategoriCommand request, CancellationToken cancellationToken)
        {
            var categories = await _categoriService.DeleteByIdAsync(request.Id);

            return new DeleteCategoriCommandResponse(categories.Id);
        }
    }
}
