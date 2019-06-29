namespace BookingForm.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public Apartment Apartment { get; set; }
        public Confirmation Confirmation { get; set; }

    }
}