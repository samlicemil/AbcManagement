using AbcManagement.Core.DataAccess.EntityFramework;
using AbcManagement.Core.Entities.Concrete;
using AbcManagement.DataAccess.Abstract;
using AbcManagement.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcManagement.DataAccess.Concrete.EntityFramework
{
    public class EfProjectDAL : EfEntityRepositoryBase<Project, AbcManagementContext>, IProjectDAL
    {
        public List<Project> GetByUser()
        {
            using (var context = new AbcManagementContext())
            {

                return context.Projects.Include(u=>u.User).ToList();
            }
        }
    }
}
