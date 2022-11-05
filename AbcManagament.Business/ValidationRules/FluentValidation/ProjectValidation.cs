using AbcManagement.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcManagament.Business.ValidationRules.FluentValidation
{
    public class ProjectValidation:AbstractValidator<Project>
    {
        public ProjectValidation()
        {
            /// kurallar genişletilebilir.
            RuleFor(p=>p.ProjectName).NotEmpty();
        }
    }
}
