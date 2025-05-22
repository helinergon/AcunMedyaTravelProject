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
    public class BookingStepsController : Controller
    {
        AcunMedyaTravelProject.Context.Context _context = new AcunMedyaTravelProject.Context.Context();
        // GET: BookingSteps
        public ActionResult Index()
        {
            var values = _context.BookingsSteps.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddBookingSteps()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBookingSteps(BookingSteps model)
        {
            _context.BookingsSteps.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteBookingSteps(int id)
        {
            var value = _context.BookingsSteps.Find(id);
            _context.BookingsSteps.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateBookingSteps(int id)
        {
            var value = _context.BookingsSteps.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateBookingSteps(BookingSteps model)
        {
            var value = _context.BookingsSteps.Find(model.BookingStepsID);
            value.StepOrder = model.StepOrder;
            value.Title = model.Title;
            value.Description = model.Description;
            value.IconeName = model.IconeName;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}