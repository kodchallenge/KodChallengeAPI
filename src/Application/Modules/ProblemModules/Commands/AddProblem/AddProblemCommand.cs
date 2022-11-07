using Kod.Application.Abstractions.Services;
using Kod.Domain.Models;
using MediatR;

namespace Kod.Application.Modules.ProblemModules.Commands
{
    public record AddProblemCommand(int CategoriId, string Title, string Description, bool IsPrivate, int Point, DateTime CreatedAt) : IRequest<AddProblemCommandResponse>;

    public record AddProblemCommandResponse(int id);

    public record AddProblemCommandHandler : IRequestHandler<AddProblemCommand, AddProblemCommandResponse>
    {
        private readonly IProblemsService _problemsService;

        public AddProblemCommandHandler(IProblemsService problemsService)
        {
            _problemsService = problemsService;
        }

        public async Task<AddProblemCommandResponse> Handle(AddProblemCommand request, CancellationToken cancellationToken)
        {

            Problems newProblem = new (request.CategoriId, request.Title, request.Description, request.IsPrivate, request.Point, request.CreatedAt);

            var addedProblem = await _problemsService.AddAsync(newProblem);

            return new AddProblemCommandResponse(addedProblem.Id);
        }
    }
}
