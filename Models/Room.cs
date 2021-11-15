using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantBookingApi.Models
{
    public class Room
    {
        [Key]
        public int Room_id { get; set; }
        public int Room_number { get; set; }
        public string Guest_Name { get; set; }
        public int Room_type_id { get; set; }
    }
}
