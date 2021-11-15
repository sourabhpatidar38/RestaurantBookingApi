using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantBookingApi.Models
{
    public class GuestsDbContext:DbContext
    {
        public DbSet<Guest> Guests { get; set; }


        public GuestsDbContext(DbContextOptions<GuestsDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Guest>().ToTable("Guest");
        }
    }
}
