using SimpleBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {

        [HttpGet]
        public ActionResult Login()
        {
            return View(new AuthLogin {
                Test = "Это храниться в Тесте при Гет"
            });
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {
            form.Test = "Это храниться при Post";
            return View(form);
        }
    }
}