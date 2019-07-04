using System;

namespace BookingForm.Models
{
    public class ReservationManagerView
    {
        public string ApartmentCode { get; private set; }
        public int NOfReserved { get; private set; }
        public string Status { get; private set; }
        public ReservationManagerView(ReservationManager item)
        {
            if (item.Apartment == null)
            {
                throw new NullReferenceException(nameof(Apartment));
            }
            if (item.Reservations == null)
            {
                throw new NullReferenceException(nameof(ReservationManager));
                
            }
            if (item.Status == null)
            {
                throw new NullReferenceException(nameof(Status));
                
            }
            this.ApartmentCode = item.Apartment.LocalCode;
            this.NOfReserved = item.Reservations.Count;
            this.Status = item.Status.GetStatus();
        }
    }
}