using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaTravelProject.Entities
{
    public class BookingSteps
    {
        public int BookingStepsID { get; set; }
        public string StepOrder {  get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
        public string IconeName { get; set; }

    }
}