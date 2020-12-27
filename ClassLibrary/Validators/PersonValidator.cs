using FluentValidation;
using FormUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        [Obsolete]
        public PersonValidator()
        {
            RuleFor(p => p.FirstName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is Empty")
                .Length(2, 50).WithMessage("Length ({TotalLength}) of {PropertyName} invalid")
                .Must(beValidName).WithMessage("{PropertyName} contains invalid Characters");
            //
            RuleFor(p => p.LastName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is Empty")
                .Length(2, 50).WithMessage("Length ({TotalLength}) of {PropertyName} invalid")
                .Must(beValidName).WithMessage("{PropertyName} contains invalid Characters");
            //
            RuleFor(p => p.EmailAddress)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is Empty")
                .Length(10, 120).WithMessage("Length ({TotalLength}) of {PropertyName} invalid")
                .EmailAddress(FluentValidation.Validators.EmailValidationMode.AspNetCoreCompatible).WithMessage("Invalid {PropertyName}");
            //
            RuleFor(p => p.PhoneNumber)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is Empty")
                .Length(10).WithMessage("Length ({TotalLength}) of {PropertyName} invalid");
        }

        public bool beValidName(string arg)
        {
            arg = arg.Replace("-", "");
            return arg.All(Char.IsLetter);
        }
    }
}
