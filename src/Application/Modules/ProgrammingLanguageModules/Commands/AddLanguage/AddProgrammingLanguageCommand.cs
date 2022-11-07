using Kod.Application.Abstractions.Services;
using Kod.Domain.Models;
using MediatR;

namespace Kod.Application.Modules.ProgrammingLanguageModules.Commands
{
    public record AddProgrammingLanguageCommand(string Name, string Slug, DateTime CreatedAt) : IRequest<AddProgrammingLanguageCommandResponse>;

    public record AddProgrammingLanguageCommandResponse(int id);

    public record AddProgrammingLanguageCommandHandler : IRequestHandler<AddProgrammingLanguageCommand, AddProgrammingLanguageCommandResponse>
    {
        private readonly IProgrammingLanguagesService _programmingLanguageService;

        public AddProgrammingLanguageCommandHandler(IProgrammingLanguagesService programmingLanguageService)
        {
            _programmingLanguageService = programmingLanguageService;
        }

        public async Task<AddProgrammingLanguageCommandResponse> Handle(AddProgrammingLanguageCommand request, CancellationToken cancellationToken)
        {

            ProgrammingLanguages newProgrammingLanguage = new (request.Name, request.Slug, request.CreatedAt);

            var addedProgrammingLanguage = await _programmingLanguageService.AddAsync(newProgrammingLanguage);

            return new AddProgrammingLanguageCommandResponse(addedProgrammingLanguage.Id);
        }
    }
}
