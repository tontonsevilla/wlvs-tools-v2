using Microsoft.AspNetCore.Mvc;
using WLVSToolsV2.Web.Models.Home;

namespace WLVSToolsV2.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new HomeViewModel());
        }
    }
}
