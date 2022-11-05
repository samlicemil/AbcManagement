using AbcManagament.Business.Abstract;
using AbcManagement.DataAccess.Abstract;
using AbcManagement.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcManagament.Business.Concrete
{
    internal class ProjectCategoryManager : IProjectCategoryService
    {
        private readonly IProjectCategoryDAL _projectCategoryDAL;

        public ProjectCategoryManager(IProjectCategoryDAL projectCategoryDAL)
        {
            _projectCategoryDAL = projectCategoryDAL;
        }

        public IResult Add(ProjectCategory projectCategory)
        {
            //Validasyonlar yazılacak 

            _projectCategoryDAL.Update(projectCategory);

            return new Result(true, "Başarılı bir şekilde kaydedidi");
        }

        public IResult Delete(int id)
        {
            //validasyon işlemleri yapılacak 
            var item = _projectCategoryDAL.Get(i => i.Id == id);
            _projectCategoryDAL.Delete(item);
            return new Result(true, "Silme işlemi başarılı bir şekilde yapılmıstır.");
        }

        public IDataResult<List<ProjectCategory>> GetAll()
        {
            //validason işlemleri yapılacaktır
            return new SuccessDataResult<List<ProjectCategory>>(_projectCategoryDAL.GetAll());
        }

        public IDataResult<ProjectCategory> GetById(int id)
        {
            //Validasyon işlemleri yapılacaktır
            return new SuccessDataResult<ProjectCategory>(_projectCategoryDAL.Get(p=>p.Id==id));
        }

        public IResult Update(ProjectCategory projectCategory)
        {
            //validasyon işlemleri yapılacaktır
            return new Result(true,"Başarı ile güncellendi");
        }
    }
}
