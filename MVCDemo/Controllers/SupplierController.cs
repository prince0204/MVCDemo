using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class SupplierController : Controller
    {
        public ActionResult Index()
        {
            ProductContext productContext = new ProductContext();
            List<Supplier> suppliers = productContext.Suppliers.ToList();
            return View(suppliers);
        }

    }
}
