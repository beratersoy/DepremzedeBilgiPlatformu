using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class NeedInfoValidator: AbstractValidator<NeedInfo>
    {
        public NeedInfoValidator()
        {
                       RuleFor(x => x.GuestId).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz!");
           
        }
    }
}
