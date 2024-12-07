using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
<<<<<<< HEAD
=======
            //Kategori ismini boş geçilmez yaptık ve uyarı mesajı verdik.
>>>>>>> c8fb2d274e66a812df4a3958b1ba61b947d09054
            RuleFor(c => c.CategoryName).NotEmpty().WithMessage("Kategory adını boş geçemezsiniz.");
        }
    }
}
