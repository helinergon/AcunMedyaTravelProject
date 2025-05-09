using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaTravelProject.Entities
{
    public class Destinations
    {
        public int DestinationsID { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }

        public string DaysTrip { get; set; }
        public int Price { get; set; }


    }
}