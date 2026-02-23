using Microsoft.AspNetCore.Mvc;

namespace WLVSToolsV2.Web.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult ModelNotFound()
        {
            return View();
        }
    }
}
