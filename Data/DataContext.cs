using Booking_Hotel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Booking_Hotel.Data
{
    public class DataContext :DbContext
    {
        public DataContext() :base ("BookingHotel") { }
        #region
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Room> Room { get; set; }
        #endregion
    }
}