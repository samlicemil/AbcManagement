using AbcManagament.Business.Abstract;
using AbcManagement.Core.Entities.Concrete;
using AbcManagement.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcManagament.Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDAL _userDAL;

        public UserManager(IUserDAL userDAL)
        {
            _userDAL = userDAL;
        }

        public void Add(User user)
        {
            throw new NotImplementedException();
        }

        public User GetByMail(string email)
        {
            throw new NotImplementedException();
        }

        public User GetByUserName(string username)
        {
            throw new NotImplementedException();
        }

        public List<OperationClaims> GetClaims(User user)
        {
            throw new NotImplementedException();
        }
    }
}
