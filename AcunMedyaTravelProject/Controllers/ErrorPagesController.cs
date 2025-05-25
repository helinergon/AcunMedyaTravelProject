using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaTravelProject.Controllers
{
  
  
    public class ErrorPagesController : Controller
    {
        public ActionResult Error()
        {
            return View("GeneralError");
        }

        public ActionResult PageNotFound()
        {
            Response.StatusCode = 404;
            return View("Index");
        }
        // GET: ErrorPages
        public ActionResult Index()
        {
            Response.StatusCode = 404;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }
    }
}