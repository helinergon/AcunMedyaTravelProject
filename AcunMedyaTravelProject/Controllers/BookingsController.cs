using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;

namespace AcunMedyaTravelProject.Controllers
{
    [Authorize]
    public class BookingsController : Controller
    {
        AcunMedyaTravelProject.Context.Context _context = new AcunMedyaTravelProject.Context.Context();
        // GET: Bookings
        public ActionResult Index()
        {
            var values = _context.Bookings.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddBookings()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBookings(Bookings model)
        {
            _context.Bookings.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteBookings(int id)
        {
            var value = _context.Bookings.Find(id);
            _context.Bookings.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateBookings(int id)
        {
            var value = _context.Bookings.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateBookings(Bookings model)
        {
            var value = _context.Bookings.Find(model.BookingsID);
            value.Title = model.Title;
            value.TravelDateStart = model.TravelDateStart;
            value.TravelDateEnd = model.TravelDateEnd;
            value.OrganizerName = model.OrganizerName;
            value.Location = model.Location;
            value.AttendeesCount = model.AttendeesCount;
            value.ImageUrl = model.ImageUrl;
            value.IsFavorite = model.IsFavorite;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}