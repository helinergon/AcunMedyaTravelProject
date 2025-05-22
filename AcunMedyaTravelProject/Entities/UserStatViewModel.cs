using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaTravelProject.Entities
{
    public class UserStatViewModel
    {
        public string Email { get; set; }
        public int LoginCount { get; set; }
        public int CommentCount { get; set; }
        public int ReservationCount { get; set; }
    }
}