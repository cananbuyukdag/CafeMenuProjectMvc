using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager:ICategoryService
    {

        public CategoryManager(ICategoryDal categoryDal)
        {
            _propertyDal = categoryDal;
        }

        public List<Category> GetList()
        {
            return _propertyDal.List();
        }

        public void CatagoryAdd(Category entity)
        {
            _propertyDal.Add(entity);
        }

        public Category GetById(int id)
        {
            return _propertyDal.GetById(x => x.CategoryId == id);
        }

        public void Delete(Category entity)
        {
            _propertyDal.Delete(entity);
        }

        public void Update(Category entity)
        {
            _propertyDal.Update(entity);
        }
    }
}
