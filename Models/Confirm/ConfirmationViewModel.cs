namespace BookingForm.Models
{
    public class ConfirmationViewModel
    {
        public Confirmation Confirm { get; set; }
        public Apartment Apartment { get; set; }
        public Reserved Reserve { get; set; }
        public Client Client { get; set; }
    }
}