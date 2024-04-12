using Entities.Concrete;
using FluentValidation;

namespace Business.DependencyResolvers.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(i=> i.FirstName).NotEmpty();
            RuleFor(i=> i.LastName).NotEmpty();
            RuleFor(i=> i.Email).NotEmpty();

        }
    }
}
