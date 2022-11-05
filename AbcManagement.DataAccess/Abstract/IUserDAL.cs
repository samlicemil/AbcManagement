using AbcManagement.Core.DataAccess;
using AbcManagement.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcManagement.DataAccess.Abstract
{
    public interface IUserDAL : IEntityRepository<User>
    {
        List<OperationClaims> GetClaims(User user);
    }
}
