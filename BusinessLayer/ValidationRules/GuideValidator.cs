using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().Length(1, 250).WithMessage("Please enter guide name and surname");
            RuleFor(x => x.Image).NotEmpty().Length(1, 250).WithMessage("Please choice guide image");
            RuleFor(x => x.Description).NotNull().NotEmpty().Length(1, 250).WithMessage("Please enter description");
        }

    }
}
