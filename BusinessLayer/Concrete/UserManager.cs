using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetList()
        {
            throw new NotImplementedException();
        }

        public void UserAdd(User user)
        {
            _userDal.Add(user);
        }

        public void UserDelete(User user)
        {
            throw new NotImplementedException();
        }

        public void UserUpdate(User user)
        {
            throw new NotImplementedException();
        }
    }
}
