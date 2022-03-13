using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RodentMedia.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RodentMedia.Controllers
{
    public class HomeController : Controller
    {
        private RodentMediaContext ratContext { get; set; }
        // Constructor
        public HomeController(RodentMediaContext someName)
        {
            ratContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMedia()
        {
            ViewBag.MediaTypes = ratContext.MediaTypes.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddMedia(RatMedia rm)
        {
            if (ModelState.IsValid)
            {
                ratContext.Add(rm);
                ratContext.SaveChanges();
                return View("Confirmation", rm);
            }
            else
            {
                ViewBag.MediaTypes = ratContext.MediaTypes.ToList();
                return View(rm);
            }

        }
        public IActionResult MediaList ()
        {
            var media = ratContext.RatMedia
                .Include( x => x.MediaType)
                .OrderBy(x => x.MediaName)
                .ToList();
            return View(media);
        }
        [HttpGet]
        public IActionResult Edit(int mediaid)
        {
            ViewBag.MediaTypes = ratContext.MediaTypes.ToList();

            var media = ratContext.RatMedia.Single(x => x.MediaId == mediaid);
            return View("AddMedia", media);
        }

        [HttpPost]
        public IActionResult Edit (RatMedia rat)
        {
            ratContext.Update(rat);
            ratContext.SaveChanges();
            return RedirectToAction("MediaList");
        }

        [HttpGet]
        public IActionResult Delete (int mediaid)
        {
            var media = ratContext.RatMedia.Single(x => x.MediaId == mediaid);
            return View(media);
        }
        [HttpPost]
        public IActionResult Delete (RatMedia rat)
        {
            ratContext.RatMedia.Remove(rat);
            ratContext.SaveChanges();

            return RedirectToAction("MediaList");
        }
        public IActionResult Thanks()
        {
            return View();
        }

    }
}
