using System;
using System.Collections.Generic;

namespace BookingForm.Models
{
    public class ReservationManagerView
    {
        public string ApartmentCode { get; private set; }
        public int NOfReserved { get; private set; }
        public string Status { get; private set; }
        public List<string> Reservations { get; private set; }
        public ReservationManagerView()
        {
            Reservations = new List<string>();
        }
        public ReservationManagerView(ReservationManager item)
        {
            Reservations = new List<string>();
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
        public void SetReservations(List<Reserved> reserved)
        {
            if (reserved == null)
            {
                throw new NullReferenceException(nameof(Reserved));
            }
            foreach (var item in reserved)
            {
                var reservedView = new ReservedViewModel(item);
                Reservations.Add(reservedView.GetInlineDetails());
            }
        }
    }
}