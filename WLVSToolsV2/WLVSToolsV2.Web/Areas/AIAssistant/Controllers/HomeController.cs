using Microsoft.AspNetCore.Mvc;

namespace WLVSToolsV2.Web.Areas.AIAssistant.Controllers
{
    [Area("AIAssistant")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
