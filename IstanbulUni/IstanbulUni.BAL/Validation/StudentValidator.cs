using FluentValidation;
using IstanbulUni.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IstanbulUni.BAL.Validation
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {

            RuleFor(x => x.StudentNo).NotEmpty().WithMessage("Öğrenci No Boş Olamaz");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Boş Olamaz");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soy İsim Boş Olamaz");
            RuleFor(x => x.UniversityName).NotEmpty().WithMessage("Üniversite ismi Boş Olamaz");
            RuleFor(x => x.examScore).NotEmpty().WithMessage("Not Boş Olamaz");
            RuleFor(x => x.examScore).LessThanOrEqualTo(100).WithMessage("Not 100'den Büyük Olamaz");
            
        }
    }
}
