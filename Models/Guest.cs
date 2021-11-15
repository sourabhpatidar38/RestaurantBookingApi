using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantBookingApi.Models
{
    public class Guest
    {
        [Key]
        public int Guest_id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Member_since { get; set; }


    }
}
