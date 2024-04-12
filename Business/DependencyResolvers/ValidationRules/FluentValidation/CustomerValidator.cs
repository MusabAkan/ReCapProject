using Entities.Concrete;
using FluentValidation;

namespace Business.DependencyResolvers.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            //RuleFor(i => i.UserId).Must(UserLimit).WithMessage("Lütfen 1 ila 3 arasında değer giriniz ");
            RuleFor(i => i.CompanyName).NotNull().WithMessage("Firma ismi boş geçilemez");
            RuleFor(i => i.CompanyName).MaximumLength(25).WithMessage("Firma adı karakter sayısı 25'den fazla olamaz");
        }

        
    }
}
