using System.Collections.Generic;

namespace BookingForm.Models
{
    public class ReservationR
    {
        public List<Room> BR3 { get; set; } = new List<Room>();
        public List<Room> BR2P { get; set; } = new List<Room>();
        public List<Room> BR2 { get; set; } = new List<Room>();
        public List<Room> BR1P { get; set; } = new List<Room>();
        public List<Room> STU { get; set; } = new List<Room>();
    }
    public class Room
    {
        public Apartment Apartment { get; set; }
        public List<Reserved> Reserveds { get; set; }
    }
}