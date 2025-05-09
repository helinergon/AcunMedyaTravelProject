using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AcunMedyaTravelProject.Entities;



namespace AcunMedyaTravelProject.Context
{
    public class Context:DbContext
    {
        public DbSet<Category> categories {  get; set; }

        public DbSet<Testimonial> testimonials { get; set; }

        public DbSet<Bookings> bookings { get; set; }

        public DbSet<Destinations> destinations { get; set; }
        
        public DbSet<Services> services { get; set; }
        
        public DbSet<Slider> sliders { get; set; }

        public DbSet<Admin> admins { get; set; }

        public DbSet<Sponsor> sponsors { get; set; }

        public DbSet<BookingSteps> bookingsSteps { get; set; }



    }
}