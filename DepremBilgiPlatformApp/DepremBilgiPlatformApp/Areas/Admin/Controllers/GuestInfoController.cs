using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using X.PagedList;

namespace DepremBilgiPlatformApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuestInfoController : Controller
    {
        GuestInfoManager gm = new GuestInfoManager(new EfGuestInfoRepository());
        public IActionResult Index(int page = 1)
        {
            var values = gm.GetList().ToPagedList(page, 15);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddGuestInfo() { return View(); }
        [HttpPost]
        public IActionResult AddGuestInfo(GuestInfo g)
        {
            GuestInfoValidator gv = new GuestInfoValidator();
            ValidationResult results = gv.Validate(g);
            if (results.IsValid)
            {
                gm.GuestInfoAdd(g);
                return RedirectToAction("Index", "GuestInfo");
            }

            return View();
        }
        public IActionResult DeleteGuestInfo(int id)
        {
            var values = gm.GetGuestInfo(id);
            gm.GuestInfoRemove(values);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateGuestInfo(int id)
        {
            var values = gm.GetGuestInfo(id);
            List<SelectListItem> homeinfovalues = (from x in gm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.GuestId.ToString()
                                                   }).ToList();
            ViewBag.hv = homeinfovalues;
            //gm.GuestInfoUpdate(values);
            return View(values);

        }
        [HttpPost]
        public IActionResult UpdateGuestInfo(GuestInfo g)
        {
            gm.GuestInfoUpdate(g);

            return RedirectToAction("Index", "GuestInfo");

        }
    }
}
