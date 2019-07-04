using System.Collections.Generic;

namespace BookingForm.Models
{
    public class ReservationManager
    {
        public Apartment Apartment {get; set;}
        public List<Reserved> Reservations { get; set; }
        public ApartmentStatus Status { get; set; }
        public ReservationManager()
        {
            Reservations = new List<Reserved>();
        }
       
    }

}