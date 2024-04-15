using Core.Entities.Concrete;
using Entities.Concrete;
using FluentValidation;
using System.Linq;

namespace Business.DependencyResolvers.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(i => i.FirstName).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(i => i.FirstName).MaximumLength(50).WithMessage("Kelime uzunluğu en fazla 50 olabilir");


            RuleFor(i => i.LastName).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(i => i.LastName).MaximumLength(50).WithMessage("Kelime uzunluğu en fazla 50 olabilir");

            RuleFor(i => i.Email).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(i => i.Email).Must(ContainMailChracter).WithMessage("@ işareti zorunludur");        


        }

        private bool ContainMailChracter(string arg)
        {
            var splits = arg.Split("@");
            return splits.Count() == 1;
        }
    }
}
