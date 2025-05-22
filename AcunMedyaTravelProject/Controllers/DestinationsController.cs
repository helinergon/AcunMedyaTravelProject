using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;

namespace AcunMedyaTravelProject.Controllers
{
    public class DestinationsController : Controller
    {
        AcunMedyaTravelProject.Context.Context _context = new AcunMedyaTravelProject.Context.Context();
        // GET: Destinations
        public ActionResult Index()
        {
            var values = _context.Destinations.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddDestinations()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDestinations(Destinations model)
        {
            _context.Destinations.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteDestinations(int id)
        {
            var value = _context.Destinations.Find(id);
            _context.Destinations.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateBookingSteps(int id)
        {
            var value = _context.Destinations.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateDestinations(Destinations model)
        {
            var value = _context.Destinations.Find(model.DestinationsID);
            value.ImageUrl = model.ImageUrl;
            value.Title = model.Title;
            value.DaysTrip = model.DaysTrip;
            value.Price = model.Price;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}