using AbcManagement.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcManagament.Business.Abstract
{
    public interface IProjectCategoryService
    {
        IDataResult<List<ProjectCategory>> GetAll();
        IDataResult<ProjectCategory> GetById(int id);
        IResult Add(ProjectCategory projectCategory);
        IResult Update(ProjectCategory projectCategory);
        IResult Delete(int productId);
    }
}
