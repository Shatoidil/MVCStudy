
using SimpleBlog.Infrastructure;
using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    [SelectedTab("posts")]
    public class PostsController : Controller
    {
        //Дает по роли админа доступ в этот раздел
        
        public ActionResult Index()
        {
            return View();
        }
    }
}