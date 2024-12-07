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
    internal class PropertyManager : IPropertyService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Delete(Property entity)
        {
            throw new NotImplementedException();
        }

        public Property GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Property> GetList()
        {
            throw new NotImplementedException();
        }

        public void PropertyAdd(Property entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Property entity)
        {
            throw new NotImplementedException();
        }
    }
}
