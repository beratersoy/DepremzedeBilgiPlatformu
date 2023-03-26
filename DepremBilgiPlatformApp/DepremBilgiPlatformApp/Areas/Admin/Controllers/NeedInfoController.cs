using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using X.PagedList;

namespace DepremBilgiPlatformApp.Areas.Admin.Controllers
{
    
    [Area("Admin")]
    public class NeedInfoController : Controller
    {
        NeedInfoManager nm = new NeedInfoManager(new EfNeedInfoRepository());
        public IActionResult Index(int page = 1)
        {
            var values = nm.GetList().ToPagedList(page, 15);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddNeedInfo() { return View(); }
        [HttpPost]
        public IActionResult AddNeedInfo(NeedInfo n)
        {
            NeedInfoValidator nv = new NeedInfoValidator();
            ValidationResult results = nv.Validate(n);
            if (results.IsValid)
            {
                nm.NeedInfoAdd(n);
                return RedirectToAction("Index", "NeedInfo");
            }

            return View();
        }
        public IActionResult DeleteNeedInfo(int id)
        {
            var values = nm.GetNeedInfo(id);
            nm.NeedInfoRemove(values);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateNeedInfo(int id)
        {
            var values = nm.GetNeedInfo(id);
            List<SelectListItem> needinfovalues = (from x in nm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Food,
                                                       Value = x.NeedInfoId.ToString()
                                                   }).ToList();
            ViewBag.nv = needinfovalues;
            //gm.GuestInfoUpdate(values);
            return View(values);

        }
        [HttpPost]
        public IActionResult UpdateNeedInfo(NeedInfo n)
        {
            nm.NeedInfoUpdate(n);

            return RedirectToAction("Index", "NeedInfo");

        }
    }
}
