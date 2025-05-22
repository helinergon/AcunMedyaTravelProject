using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AcunMedyaTravelProject.Entities;

namespace AcunMedyaTravelProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        AcunMedyaTravelProject.Context.Context _Context = new AcunMedyaTravelProject.Context.Context();

        // GET: Login
        public ActionResult Index()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return View();
        }


       
        [HttpPost]
        public ActionResult Index(Admin model)
        {
            var Admin = _Context.Admins.FirstOrDefault(x => x.UserName == model.UserName && x.Password == model.Password);
            if (Admin == null)
            {
                ModelState.AddModelError(string.Empty, "Kullanıcı adı veya şifre hatalı");
                return View(model);
            }

            // LoginCount'u artır
            Admin.LoginCount = (Admin.LoginCount) + 1;  // Eğer nullable ise null kontrolü ile
            _Context.SaveChanges();

            FormsAuthentication.SetAuthCookie(Admin.UserName, false);
            Session["currentUser"] = Admin.UserName;

            return RedirectToAction("Index", "Services");
        }


        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }

    }
}