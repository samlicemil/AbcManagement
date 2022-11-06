using AbcManagement.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcManagament.Business.Abstract
{
    public interface IProjectService
    {
        IDataResult<List<Project>> GetAll();
        IDataResult<List<Project>> GetUser();
        IDataResult<List<Project>> GetAllByCategoryId(int id);
        IDataResult<Project> GetById(int id);
        IResult Add(Project project);
        IResult Update(Project project);
    }
}
