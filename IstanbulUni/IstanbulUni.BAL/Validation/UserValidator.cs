using FluentValidation;
using IstanbulUni.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IstanbulUni.BAL.Validation
{
    public class UserValidator:AbstractValidator<User>
    {
        
        public UserValidator()
        {
                RuleFor(x=>x.Email).NotEmpty().WithMessage("Email Boş Olamaz");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Boş Olamaz");

        }
    }
}
