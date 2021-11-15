using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantBookingApi.Models;

namespace RestaurantBookingApi.Data
{
    public class RoomApiContext : DbContext
    {
        public RoomApiContext (DbContextOptions<RoomApiContext> options)
            : base(options)
        {
        }

        public DbSet<RestaurantBookingApi.Models.Room> Room { get; set; }
    }
}
