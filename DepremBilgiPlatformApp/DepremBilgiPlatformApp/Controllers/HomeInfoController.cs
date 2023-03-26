using BusinessLayer.Concrete;
using DataAcessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DepremBilgiPlatformApp.Controllers
{
    [Authorize]
    public class HomeInfoController : Controller
    {
        HomeInfoManager hm = new HomeInfoManager(new EfHomeInfoRepository()); 
        public IActionResult Index()
        {
            var values = hm.GetList();
            return View(values);
        }
    }
}
