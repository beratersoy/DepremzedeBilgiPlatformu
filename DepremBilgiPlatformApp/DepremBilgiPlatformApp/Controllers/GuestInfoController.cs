using Microsoft.AspNetCore.Mvc;

namespace DepremBilgiPlatformApp.Controllers
{
    public class GuestInfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
