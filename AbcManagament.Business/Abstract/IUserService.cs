using AbcManagement.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcManagament.Business.Abstract
{
    internal interface IUserService
    {
        List<OperationClaims> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
        User GetByUserName(string username);
    }
}
