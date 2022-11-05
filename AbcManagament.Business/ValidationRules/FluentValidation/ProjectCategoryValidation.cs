using AbcManagement.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcManagament.Business.ValidationRules.FluentValidation
{
    public class ProjectCategoryValidation : AbstractValidator<ProjectCategory>
    {

        
        public ProjectCategoryValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Boş Bırakılamaz");
        }

       
    }
}
