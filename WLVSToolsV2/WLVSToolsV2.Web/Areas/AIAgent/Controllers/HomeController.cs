using Microsoft.AspNetCore.Mvc;

namespace WLVSToolsV2.Web.Areas.AIAgent.Controllers
{
    [Area("AIAgent")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
