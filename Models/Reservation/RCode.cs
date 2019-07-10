namespace BookingForm.Models
{
    public class RCode
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public bool IsUsed { get; set; }
        public void Dispose()
        {
            IsUsed = true;
        }
    }
}