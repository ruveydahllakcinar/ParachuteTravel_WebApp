
using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.ContactUsValidationRules
{
    public class SendContactUsValidator : AbstractValidator<SendMessageDto>
    {

        public SendContactUsValidator() 
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail field cannot be empty!");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name field cannot be empty!");
            RuleFor(x => x.Subject).NotEmpty().MaximumLength(100).WithMessage("Please write subject no more than 100 characters!");
            RuleFor(x => x.Subject).NotEmpty().MinimumLength(10).WithMessage("Please write the subject as at least 10 characters!");
            RuleFor(x => x.MessageBody).NotEmpty().MaximumLength(600).WithMessage("Please write message no more than 600 characters!");
        }
    }
}
