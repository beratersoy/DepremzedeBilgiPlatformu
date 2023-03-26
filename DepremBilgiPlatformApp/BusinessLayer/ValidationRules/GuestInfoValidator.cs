using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuestInfoValidator: AbstractValidator<GuestInfo>
    {
        public GuestInfoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz!");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz!");
            RuleFor(x => x.PersonCount).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz!");
            RuleFor(x => x.HomeInfoId).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz!");
        }
    }
}
