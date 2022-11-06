using AbcManagament.Business.Abstract;
using AbcManagement.Core.Entities.Concrete;
using AbcManagement.DataAccess.Abstract;
using AbcManagement.DataAccess.Concrete.EntityFramework;
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
            _userDAL.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDAL.Get(u => u.Email == email);
        }

        public User GetByUserName(string username)
        {
            return _userDAL.Get(u => u.UserName == username);
        }

        public List<OperationClaims> GetClaims(User user)
        {
            return _userDAL.GetClaims(user);
        }
    }
}
