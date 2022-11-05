using AbcManagament.Business.Abstract;
using AbcManagament.Business.ValidationRules.FluentValidation;
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
    internal class ProjectManager : IProjectService
    {
        
        private readonly IProjectDAL _projectDAL;

        public ProjectManager(IProjectDAL projectDAL)
        {
            _projectDAL = projectDAL;
        }
        public IResult Add(Project project)
        {

            // Gerekli Validationlar yapılacak .. 
           _projectDAL.Add(project);

            return new Result(true,"Başarılı bir şekilde kaydedidi");
        }

        public IDataResult<List<Project>> GetAll()
        {
            // Gerekli Validationlar yapılacak .. 

            return new SuccessDataResult<List<Project>>(_projectDAL.GetAll());
        }

        public IDataResult<List<Project>> GetAllByCategoryId(int id)
        {
            // Gerekli Validationlar yapılacak .. 

            return new SuccessDataResult<List<Project>>(_projectDAL.GetAll(p=>p.ProjectCategoryId==id));
        }

        public IDataResult<Project> GetById(int id)
        {
            // Gerekli Validationlar yapılacak .. 


            return new SuccessDataResult<Project>(_projectDAL.Get(p => p.Id == id));
        }

      
        public IResult Update(Project project)
        {
            // Gerekli Validationlar yapılacak .. 

            _projectDAL.Update(project);

            return new Result(true, "Başarılı bir şekilde güncellendi");
        }
    }
}
