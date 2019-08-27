using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index(int supplierId)
        {
            ProductContext productContext = new ProductContext();
            List<Product> products = productContext.Products.Where(pro => pro.SupplierId==supplierId).ToList();

            return View(products);
        }
        public ActionResult Details(int id)
        {
            ProductContext productContext = new ProductContext();
            Product product = productContext.Products.Single(pro => pro.Id == id);

            return View(product);
        }

    }
}
