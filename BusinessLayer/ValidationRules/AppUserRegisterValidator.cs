using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<UserRegisterDTO>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name field cannot be empty");
            RuleFor(x=>x.Surname).NotEmpty().WithMessage("Surname field cannot be empty");
            RuleFor(x=>x.Email).NotEmpty().WithMessage("Email field cannot be empty");
            RuleFor(x=>x.Username).NotEmpty().WithMessage("Username field cannot be empty");
            RuleFor(x=>x.Password).NotEmpty().WithMessage("Password field cannot be empty");
            RuleFor(x=>x.ConfirmPassword).NotEmpty().WithMessage("ConfirmPassword field cannot be empty");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Passwords do not match");
        }
    }
}
