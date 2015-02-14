using Web.Models;
using System.Linq;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            const int count = 20;

            ViewBag.Limit = count;

            // get the most recent comments
            var recent = Comments.All.Take(count);

            return View(recent);
        }
    }
}