using FluentValidation;
using FluentValidation.Validators;
using Hospital_Management_System_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Fluent_Validation.Configurations
{
    public class EmployeeValidation : AbstractValidator<Employees>
    {
        public EmployeeValidation()
        {
            RuleFor(x => x.FirstName).NotNull().MaximumLength(255)
                .WithMessage("The name provided does not meet the required format for a person's name."); ;

            RuleFor(x => x.LastName).NotNull().MaximumLength(255)
                .WithMessage("The name provided does not meet the required format for a person's name."); ;

            RuleFor(x => x.Email).EmailAddress()
                .WithMessage("The email address provided is not valid. Please ensure that you have entered a valid email address in the correct format.");
        }
    }
}
