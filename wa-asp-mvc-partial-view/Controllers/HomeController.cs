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

        [HttpGet]
        public ActionResult UploadFile() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadFile(string name, HttpPostedFileBase file)
        {
            if(file != null) 
            {
                file.SaveAs(Server.MapPath($"~/Upload/{file.FileName}"));
            }

            return View();
        }

    }
}