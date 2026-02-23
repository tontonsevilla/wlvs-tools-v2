using Microsoft.AspNetCore.Mvc;

namespace WLVSToolsV2.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
