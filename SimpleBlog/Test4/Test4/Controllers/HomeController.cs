using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test4.Models;
namespace Test4.Controllers
{

    public class HomeController : Controller
    {
        public PeoplesEntities1 db = new PeoplesEntities1();
        // GET: Home
        public ActionResult Index()
        {
           
            return View(db.Peoples.ToList());
        }
        [HttpPost]
        public ActionResult Index(string sexType)
        {
            ViewBag.PersonType = sexType;
            return View();
        }
        public ActionResult GetPersons(string sexType)
        {
            int sex = 2;
            if (sexType == "Женщины")
            {
                sex = 0;
            }
            else if(sexType == "Мужчины")
            {
                sex = 1;
            }
            var result = sex == 2 ? db.Peoples : db.Peoples.Where(x => x.Sex == sex);
            result.ToList();
           
            

            return View(result.ToList());
        }
    }
}