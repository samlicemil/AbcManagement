using AbcManagement.Core.DataAccess.EntityFramework;
using AbcManagement.DataAccess.Abstract;
using AbcManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcManagement.DataAccess.Concrete.EntityFramework
{
    public class EfProjectDAL:EfEntityRepositoryBase<ProjectCategory, AbcManagementContext>,IProjectCategoryDAL
    {
    }
}
