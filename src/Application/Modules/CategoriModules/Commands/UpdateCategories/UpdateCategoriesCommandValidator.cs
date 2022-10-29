using FluentValidation;
using Kod.Application.Constants.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kod.Application.Modules.CategoriModules.Commands.UpdateCategories
{
    public class UpdateCategoriesCommandValidator : AbstractValidator<UpdateCategoriesCommand>
    {
        public UpdateCategoriesCommandValidator()
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
