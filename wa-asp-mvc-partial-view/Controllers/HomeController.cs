using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace wa_asp_mvc_partial_view.Controllers
{
    public class HomeController : Controller
    {
        string[] products = { "Кефір", "Батон", "Стакан" };
        string[] category = { "Алкоголь", "Їжа" };

        // GET: Home
        public ActionResult Index(int? count)
        {
            return View(products);
        }

        public ActionResult _Partial() 
        {
            return PartialView(category);
        }
    }
}