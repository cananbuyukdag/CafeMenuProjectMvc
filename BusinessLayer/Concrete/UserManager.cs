using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
<<<<<<< HEAD
using DataAccsessLayer.EntityFramework;
=======
>>>>>>> c8fb2d274e66a812df4a3958b1ba61b947d09054
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
<<<<<<< HEAD
            return _userDal.GetById(x => x.UserId == id);
=======
            throw new NotImplementedException();
>>>>>>> c8fb2d274e66a812df4a3958b1ba61b947d09054
        }

        public List<User> GetList()
        {
<<<<<<< HEAD
            return _userDal.List();
=======
            throw new NotImplementedException();
>>>>>>> c8fb2d274e66a812df4a3958b1ba61b947d09054
        }

        public void UserAdd(User user)
        {
            _userDal.Add(user);
        }

        public void UserDelete(User user)
        {
<<<<<<< HEAD
            _userDal.Delete(user);
=======
            throw new NotImplementedException();
>>>>>>> c8fb2d274e66a812df4a3958b1ba61b947d09054
        }

        public void UserUpdate(User user)
        {
<<<<<<< HEAD
            _userDal.Update(user);
=======
            throw new NotImplementedException();
>>>>>>> c8fb2d274e66a812df4a3958b1ba61b947d09054
        }
    }
}
