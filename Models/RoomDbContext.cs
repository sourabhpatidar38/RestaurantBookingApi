using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantBookingApi.Models
{
    public class RoomDbContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }


        public RoomDbContext(DbContextOptions<RoomDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().ToTable("Room");
        }
    }
}
