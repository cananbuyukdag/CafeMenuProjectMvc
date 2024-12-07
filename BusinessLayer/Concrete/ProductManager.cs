using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccsessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
<<<<<<< HEAD
    public class ProductManager : IProductService
=======
    internal class ProductManager : IProductService
>>>>>>> c8fb2d274e66a812df4a3958b1ba61b947d09054
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
<<<<<<< HEAD


=======
>>>>>>> c8fb2d274e66a812df4a3958b1ba61b947d09054
        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(x => x.ProductId == id);
        }

        public List<Product> GetList()
        {
            return _productDal.List();
        }

        public void ProductAdd(Product entity)
        {
            _productDal.Add(entity);
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
