using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BussinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz...!");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("görsel seçiniz");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("lütfen 50 karakterlik giriniz");
        }
    }
}
