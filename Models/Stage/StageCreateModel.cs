using System.Collections.Generic;

namespace BookingForm.Models
{
    public class StageCreateModel
    {
        public List<RCode> Code { get; set; }
        public List<Apartment> Apartment { get; set; }
        public bool IsRunning { get; set; }
    }
}