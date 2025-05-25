using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaTravelProject.Entities;

namespace AcunMedyaTravelProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        AcunMedyaTravelProject.Context.Context _Context = new AcunMedyaTravelProject.Context.Context();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialBookings()
        {
            var values = _Context.Bookings.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialBookingSteps()
        {
            var values = _Context.BookingsSteps.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialDestinations()
        {
            var values = _Context.Destinations.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialServices()
        {
            var values = _Context.Services.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSponsor()
        {
            var values = _Context.Sponsors.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonial()
        {
            var values = _Context.Testimonials.ToList();
            return PartialView(values);
        }
    }

}