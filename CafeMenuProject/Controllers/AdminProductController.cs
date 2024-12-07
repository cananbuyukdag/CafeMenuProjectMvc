using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using BusinessLayer.Validationrules;
using BusinessLayer.ValidationRules;
using DataAccsessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;

namespace CafeMenuProject.Controllers
{
    public class AdminProductController : Controller
    {
        private ProductManager _product = new ProductManager(new EfProductDal());
        private CategoryManager cm = new CategoryManager(new EfCategoryDal());
        private UserManager wm = new UserManager(new EfUserDal());

        public ActionResult Index()
        {
            var c = _product.GetList();
            return View(c);
        }

        [HttpGet]
        public ActionResult ProductAdd()
        {
            List<SelectListItem> valueItems = (from x in cm.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryId.ToString()
                                               }).ToList();

            List<SelectListItem> valueWriter = (from x in wm.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.Name + " " + x.Surname,
                                                    Value = x.UserId.ToString()
                                                }).ToList();

            ViewBag.ItemsWriter = valueWriter;

            ViewBag.Items = valueItems;
            return View();
        }

        [HttpPost]
        public ActionResult ProductAdd(Product entity)
        {
            ProductValidator validator = new ProductValidator();
            ValidationResult result = validator.Validate(entity);
            if (result.IsValid)
            {
                _product.ProductAdd(entity);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int? id)
        {
            var _id = id ?? 0;
            var c = _product.GetById(_id);
            _product.Delete(c);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var c = _product.GetById(id);
            return View(c);
        }

        [HttpPost]
        public ActionResult Update(Product entity)
        {
            _product.Update(entity);
            return RedirectToAction("Index");
        }
    }
}