using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Booking_Hotel.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name {  get; set; }
        [Required]
        public string Email { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        [Required]
        public int Adults { get; set; }
        public Nullable<int> Children { get; set; }
        [Required]
        public int NumberRoom { get; set; }
        public Nullable<long> RoomId { get; set; }
        public virtual Room Room { get; set; }
    }
}