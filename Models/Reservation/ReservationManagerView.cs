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
            item = null;
            Reservations = new List<string>();
            try
            {
                this.ApartmentCode = item.Apartment.LocalCode;
                this.NOfReserved = item.Reservations.Count;
                this.Status = item.Status.GetStatus();
                
            }
            catch (ExceptionHandler<ReservationManager> e) when (LogException(e))
            {
                
            }
            
        }
        private static bool LogException(ExceptionHandler<ReservationManager> e)
        {
            System.Console.WriteLine(e.Message);
            return false;
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
                Reservations.Add(reservedView.ToString());
            }
        }
    }
}