using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using X.PagedList;

namespace DepremBilgiPlatformApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeInfoController : Controller
    {
        HomeInfoManager hm = new HomeInfoManager(new EfHomeInfoRepository());
        public IActionResult Index(int page = 1)
        {
            var values = hm.GetList().ToPagedList(page, 15);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddHomeInfo() { return View(); }
        [HttpPost]
        public IActionResult AddHomeInfo(HomeInfo h)
        {
            HomeInfoValidator hv = new HomeInfoValidator();
            ValidationResult results = hv.Validate(h);
            if (results.IsValid)
            {
                hm.HomeInfoAdd(h);
                return RedirectToAction("Index", "HomeInfo");
            }

            return View();
        }
        public IActionResult DeleteHomeInfo(int id) {
            var values = hm.GetHomeInfo(id);
            hm.HomeInfoRemove(values);
            return RedirectToAction("Index");
        
        }
        [HttpGet]
        public IActionResult UpdateHomeInfo(int id)
        {
            var values = hm.GetHomeInfo(id);
            List<SelectListItem> homeinfovalues = (from x in hm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.HomeInfoId.ToString()
                                                   }).ToList();
            ViewBag.hv = homeinfovalues;
            //hm.HomeInfoUpdate(values);
            return View(values);

        }
        [HttpPost]
        public IActionResult UpdateHomeInfo(HomeInfo h)
        {
            hm.HomeInfoUpdate(h);  
           
            return RedirectToAction("Index", "HomeInfo");

        }

    }
}
