using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PreCompiledView.Areas.Contact
{
    public class HomeController : Controller
    {
        //
        // GET: /Contact/Home/

        public ActionResult Index()
        {
            return View();
        }

    }
}
