using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class HomeInfoValidator : AbstractValidator<HomeInfo>  
    {
        public HomeInfoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz!");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz!");
            RuleFor(x => x.IdentityNumber).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz!");
            RuleFor(x => x.GuestCount).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz!");
        }
    }
}
