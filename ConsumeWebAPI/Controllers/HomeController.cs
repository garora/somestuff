using System.Web.Mvc;

namespace ConsumeWebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "This is a demo app showing how to consume asp.net web api using RestSharp.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About demo app.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page.";

            return View();
        }
    }
}
