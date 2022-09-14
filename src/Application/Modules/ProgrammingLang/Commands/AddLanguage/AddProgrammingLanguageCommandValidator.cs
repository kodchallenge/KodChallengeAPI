
using FluentValidation;
using Kod.Application.Constants.Messages;
using Kod.Application.Modules.ProgrammingLang.Commands;

namespace Kod.Application.Modules.ProgrammingLang.Validators
{
    public class AddProgrammingLanguageCommandValidator : AbstractValidator<AddProgrammingLanguageCommand>
    {
        public AddProgrammingLanguageCommandValidator()
        {
            RuleFor(s => s.Name).NotEmpty().WithMessage(Messages.NotEmpty);
            RuleFor(s => s.Name).NotNull().WithMessage(Messages.NotNull);
            RuleFor(s => s.Name).Length(1, 24).WithMessage(Messages.LanguageNameLengthMustBetween1And24);
        
            RuleFor(s => s.Slug).NotEmpty().WithMessage(Messages.NotEmpty);
            RuleFor(s => s.Slug).NotNull().WithMessage(Messages.NotNull);
            RuleFor(s => s.Slug).Length(1, 24).WithMessage(Messages.LanguageNameLengthMustBetween1And24);
        }
    }
}
