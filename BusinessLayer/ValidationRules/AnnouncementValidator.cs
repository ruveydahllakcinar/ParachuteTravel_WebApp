using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator:AbstractValidator<AnnouncementAddDTO>
    {
        public AnnouncementValidator()
        {

            RuleFor(x => x.Title).NotEmpty().WithMessage("Title field cannot be empty!");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Content field cannot be empty!");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Please write content no more than 500 characters!");

        }
    }
}
