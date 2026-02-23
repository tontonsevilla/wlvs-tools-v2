using Microsoft.AspNetCore.Mvc;
using WLVSToolsV2.Web.Areas.AIAgent.Models.Home;

namespace WLVSToolsV2.Web.Areas.AIAgent.Controllers
{
    [Area("AIAgent")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new HomeViewModel());
        }
    }
}
