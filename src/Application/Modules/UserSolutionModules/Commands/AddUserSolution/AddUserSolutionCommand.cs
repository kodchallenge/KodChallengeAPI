using Kod.Application.Abstractions.Services;
using Kod.Domain.Models;
using MediatR;

namespace Application.Modules.UserSolutionModules.Commands
{
    public record AddUserSolutionCommand(int UserId, string SolutionPath, int Score, DateTime CreatedAt) : IRequest<AddUserSolutionCommandResponse>;

    public record AddUserSolutionCommandResponse(int id);

    public record AddUserSolutionCommandHandler : IRequestHandler<AddUserSolutionCommand, AddUserSolutionCommandResponse>
    {
        private readonly IUserSolutionsService _userSolutionsService;

        public AddUserSolutionCommandHandler(IUserSolutionsService userSolutionsService)
        {
            _userSolutionsService = userSolutionsService;
        }

        public async Task<AddUserSolutionCommandResponse> Handle(AddUserSolutionCommand request, CancellationToken cancellationToken)
        {

            UserSolutions newUserSolution = new(request.UserId, request.SolutionPath, request.Score, request.CreatedAt);

            var addedUserSolution = await _userSolutionsService.AddAsync(newUserSolution);

            return new AddUserSolutionCommandResponse(addedUserSolution.Id);
        }
    }
}
