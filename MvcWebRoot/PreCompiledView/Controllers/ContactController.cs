using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PreCompiledView.Models;

namespace PreCompiledView.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        public ActionResult Index()
        {
            var viewModel = new ContactViewModel();
            viewModel.Name = "This is where the magic happens..!";
            return View(viewModel);
        }

    }
}
