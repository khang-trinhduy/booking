namespace BookingForm.Models
{
    public class Confirmation
    {
        public int Id { get; set; }
        public string RCC { get; set; }
        public string LocalCode { get; set; }
        public int ClientId { get; set; } 
    }
}