
using FluentValidation;
using Kod.Application.Constants.Messages;
using Kod.Application.Modules.ProblemModules.Commands;

namespace Kod.Application.Modules.ProblemModules.Validators
{
    public class AddProblemCommandValidator : AbstractValidator<AddProblemCommand>
    {
        public AddProblemCommandValidator()
        {
            RuleFor(s => s.CategoriId).NotEmpty().WithMessage(Messages.NotEmpty);
            RuleFor(s => s.CategoriId).NotNull().WithMessage(Messages.NotNull);
            
            RuleFor(s => s.Title).NotEmpty().WithMessage(Messages.NotEmpty);
            RuleFor(s => s.Title).NotNull().WithMessage(Messages.NotNull);

            RuleFor(s => s.Description).NotEmpty().WithMessage(Messages.NotEmpty);

            RuleFor(s => s.IsPrivate).NotEmpty().WithMessage(Messages.NotEmpty);
            RuleFor(s => s.IsPrivate).NotNull().WithMessage(Messages.NotNull);

            RuleFor(s => s.Point).NotEmpty().WithMessage(Messages.NotEmpty);
            RuleFor(s => s.Point).NotNull().WithMessage(Messages.NotNull);

            RuleFor(s => s.CreatedAt).NotEmpty().WithMessage(Messages.NotEmpty);
            RuleFor(s => s.CreatedAt).NotNull().WithMessage(Messages.NotNull);

        }
    }
}
