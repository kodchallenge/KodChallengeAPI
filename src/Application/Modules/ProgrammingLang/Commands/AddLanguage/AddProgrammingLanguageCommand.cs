using Kod.Application.Abstractions.Repositories;
using Kod.Application.Abstractions.Services;
using Kod.Domain.Models;
using MediatR;

namespace Kod.Application.Modules.ProgrammingLang.Commands
{
    public record AddProgrammingLanguageCommand(string Name, string Slug) : IRequest<AddProgrammingLanguageCommandResponse>;

    public record AddProgrammingLanguageCommandResponse(int id);

    public record AddProgrammingLanguageCommandHandler : IRequestHandler<AddProgrammingLanguageCommand, AddProgrammingLanguageCommandResponse>
    {
        private readonly IProgrammingLanguageService _programmingLanguageService;

        public AddProgrammingLanguageCommandHandler(IProgrammingLanguageService programmingLanguageService)
        {
            _programmingLanguageService = programmingLanguageService;
        }

        public async Task<AddProgrammingLanguageCommandResponse> Handle(AddProgrammingLanguageCommand request, CancellationToken cancellationToken)
        {

            ProgrammingLanguage newProgrammingLanguage = new (request.Name, request.Slug);

            var addedProgrammingLanguage = await _programmingLanguageService.AddAsync(newProgrammingLanguage);

            return new AddProgrammingLanguageCommandResponse(addedProgrammingLanguage.Id);
        }
    }
}
