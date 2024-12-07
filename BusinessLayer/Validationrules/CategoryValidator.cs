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
            //Kategori ismini boş geçilmez yaptık ve uyarı mesajı verdik.
            RuleFor(c => c.CategoryName).NotEmpty().WithMessage("Kategory adını boş geçemezsiniz.");
        }
    }
}
