namespace BookingForm.Models
{
    public class ApartmentStatus
    {
        public Apartment Apartment { private get; set; }
        public string Status;
        public ApartmentStatus(Apartment apartment)
        {
            Apartment = apartment;
        }
        public void SetStatus(bool confirmed, bool reserved, bool holding)
        {
            if (confirmed)
            {
                Status = "Closed";
                return;
            }
            if (reserved)
            {
                Status = "Opening";
                return;
            }
            if (holding)
            {
                Status = "Holding";
                return;
            }
        }
        public string GetStatus()
        {
            return this.Status;
        }
    }
}