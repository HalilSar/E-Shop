using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Commands.CreateCustomer
{
    public class CreateCustomerValidator : AbstractValidator<CreateCustomerRequest>
    {
        public CreateCustomerValidator()
        {
            // CreateCustomerRequest validation.
	    RuleFor(x => x.Firstname).NotEmpty().NotNull().WithMessage("Lüften bir isim verin.").MinimumLength(3).MaximumLength(20)
                .WithMessage("Lütfen girilen isim 3 ila 20 arasında bir karakter içersin");
            RuleFor(x=>x.LastName).NotEmpty().NotNull().WithMessage("Lüften bir isim verin.").MinimumLength(3).MaximumLength(20)
                .WithMessage("Lütfen girilen değer 3 ila 20 arasında bir karakter içersin");
           RuleFor(x => x.Password).NotEmpty().NotNull().WithMessage("Lüften bir isim verin.").MinimumLength(3).MaximumLength(20)
                .WithMessage("Lütfen girilen isim 3 ila 20 arasında bir karakter içersin");
            RuleFor(x => x.Email).NotEmpty().NotNull().WithMessage("Lüften bir isim verin.").EmailAddress()
                .WithMessage("Lütfen email adresini doğru girin.");
           


        }
    }
}
