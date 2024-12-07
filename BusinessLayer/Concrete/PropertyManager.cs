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
    internal class PropertyManager : IPropertyService
    {
<<<<<<< HEAD
        IPropertyDal _propertyDal;

        public PropertyManager(IPropertyDal propertyDal)
        {
            _propertyDal = propertyDal;
=======
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
>>>>>>> c8fb2d274e66a812df4a3958b1ba61b947d09054
        }

        public void Delete(Property entity)
        {
<<<<<<< HEAD
            _propertyDal.Delete(entity);
=======
            throw new NotImplementedException();
>>>>>>> c8fb2d274e66a812df4a3958b1ba61b947d09054
        }

        public Property GetById(int id)
        {
<<<<<<< HEAD
            return _propertyDal.GetById(x => x.PropertyId == id);
=======
            throw new NotImplementedException();
>>>>>>> c8fb2d274e66a812df4a3958b1ba61b947d09054
        }

        public List<Property> GetList()
        {
<<<<<<< HEAD
            return _propertyDal.List();
=======
            throw new NotImplementedException();
>>>>>>> c8fb2d274e66a812df4a3958b1ba61b947d09054
        }

        public void PropertyAdd(Property entity)
        {
<<<<<<< HEAD
            _propertyDal.Add(entity);
=======
            throw new NotImplementedException();
>>>>>>> c8fb2d274e66a812df4a3958b1ba61b947d09054
        }

        public void Update(Property entity)
        {
<<<<<<< HEAD
            _propertyDal.Update(entity);
=======
            throw new NotImplementedException();
>>>>>>> c8fb2d274e66a812df4a3958b1ba61b947d09054
        }
    }
}
