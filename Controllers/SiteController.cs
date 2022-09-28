using System.Web.Mvc;

namespace NirmayaGlobal.Controllers
{
    public class SiteController : Controller
    {
        // GET: Site
        public ActionResult PortalHome()
        {
            ViewData["Title"] = "Welcome to Nirmaya LLC.";

            return View();
        }
    }
}