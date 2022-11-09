using Application.Modules.UserSolutionModules.Commands;
using FluentValidation;
using Kod.Application.Constants.Messages;

namespace Application.Modules.UserSolutionModules.Validators
{
    internal class AddUserSolutionCommandValidator : AbstractValidator<AddUserSolutionCommand>
    {
        public AddUserSolutionCommandValidator()
        {
            RuleFor(s => s.UserId).NotEmpty().WithMessage(Messages.NotEmpty);
            RuleFor(s => s.UserId).NotNull().WithMessage(Messages.NotNull);

            RuleFor(s => s.SolutionPath).NotEmpty().WithMessage(Messages.NotEmpty);
            RuleFor(s => s.SolutionPath).NotNull().WithMessage(Messages.NotNull);
            
            RuleFor(s => s.Score).NotEmpty().WithMessage(Messages.NotEmpty);
            RuleFor(s => s.Score).NotNull().WithMessage(Messages.NotNull);
        }

    }
}
