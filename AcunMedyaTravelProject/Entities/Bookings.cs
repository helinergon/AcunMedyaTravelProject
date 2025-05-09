using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaTravelProject.Entities
{
    public class Bookings
    {
        public int BookingsID { get; set; }
        public string Title { get; set; }
        public string TravelDateStart { get; set; }

        public string TravelDateEnd { get; set; }
        public string OrganizerName { get; set; }
        public string Location { get; set; }
        public string AttendeesCount { get; set; }
        public string ImageUrl { get; set; }
        public string IsFavorite { get; set; }


    }
}