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
                Test = "Это храниться в Тесте"
            }
            );
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {
            return View();
        }
    }
}