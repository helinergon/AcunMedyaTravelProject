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
    public class StatisticsController : Controller
    {
        AcunMedyaTravelProject.Context.Context _context = new AcunMedyaTravelProject.Context.Context();
        // GET: Statistics

        public ActionResult Index()
        {

            ViewBag.BookingsCount= _context.Bookings.Count();
            ViewBag.BookingStepsCount = _context.BookingsSteps.Count();
            ViewBag.CategoryCount = _context.Categories.Count();
            ViewBag.DestinationsCount = _context.Destinations.Count();
            ViewBag.LoginCount = _context.Admins.Count();
            ViewBag.ServicesCount = _context.Services.Count();
            ViewBag.SliderCount = _context.Sliders.Count();
            ViewBag.SponsorCount = _context.Sponsors.Count();
            ViewBag.TestimonialCount = _context.Testimonials.Count();
            ViewBag.AdminCount = _context.Admins.Count();
            ViewBag.CommentCount = _context.Testimonials.Count();
            ViewBag.ReservationCount = _context.Bookings.Count();

            var userStats = _context.Admins.Select(admin => new UserStatViewModel
            {
                Email = admin.Email,
                LoginCount = admin.LoginCount,
                CommentCount = _context.Testimonials.Count(t => t.TestimonialID == admin.AdminID),
                ReservationCount = _context.Bookings.Count(b => b.BookingsID == admin.AdminID)
            }).ToList();
           

            ViewBag.UserStats = userStats;

            return View();
        }

       
    }
}