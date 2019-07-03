namespace BookingForm.Models
{
    public class ConfirmationList
    {
        public string ApartmentCode { get; set; }
        public string Client { get; set; }
        public bool IsReserved { get; set; }
        public int NOReserved { get; set; }
    }
}