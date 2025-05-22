using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;

namespace AcunMedyaTravelProject.Controllers
{
    public class SliderController : Controller
    {
        AcunMedyaTravelProject.Context.Context _context = new AcunMedyaTravelProject.Context.Context();
        // GET: Slider
        public ActionResult Index()
        {
            var values = _context.Sliders.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddSlider()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSlider(Slider model)
        {
            _context.Sliders.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSlider(int id)
        {
            var value = _context.Sliders.Find(id);
            _context.Sliders.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSlider(int id)
        {
            var value = _context.Sliders.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSlider(Slider model)
        {
            var value = _context.Sliders.Find(model.SliderID);
            value.Title= model.Title;
            value.Description1= model.Description1;
            value.Description2= model.Description2;
            value.ImageUrl= model.ImageUrl;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}