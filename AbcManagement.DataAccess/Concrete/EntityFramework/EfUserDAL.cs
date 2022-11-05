using AbcManagement.Core.DataAccess.EntityFramework;
using AbcManagement.Core.Entities.Concrete;
using AbcManagement.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcManagement.DataAccess.Concrete.EntityFramework
{
    public class EfUserDAL : EfEntityRepositoryBase<User, AbcManagementContext>, IUserDAL
    {
        public List<OperationClaims> GetClaims(User user)
        {
            using (var context = new AbcManagementContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaims { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}
