using FluentValidation;
using TCC.Educacional.Api.Models;

namespace TCC.Educacional.Api.Validator
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Por favor, especifique um nome").MaximumLength(100);
            RuleFor(x => x.Password).NotEmpty().WithMessage("Por favor, especifique uma senha").MaximumLength(100);
        }
    }
}
