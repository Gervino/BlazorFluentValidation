using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFluentValidation.Data
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }

    public class EmployeeValidator: AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("You must enter a name");
            RuleFor(p => p.Name).MaximumLength(50).WithMessage("Name can not be longer than 50 char");

            RuleFor(p => p.Age).NotEmpty().WithMessage("Age must be greater than 0");
            RuleFor(p => p.Age).LessThan(100).WithMessage("Age can not be greater than 100");

            RuleFor(p => p.Email).NotEmpty().WithMessage("You must enter a email address");
            RuleFor(p => p.Email).EmailAddress().WithMessage("You must enter a valid email address");

        }
    }
}
