using System;

namespace BookingForm.Models
{
    public class Download
    {
        public int Id { get; set; }
        public string QRCode { get; set; }
        public string File { get; set; }
        public Byte[] Image { get; set; }
        public int PrintId { get; set; }
        public virtual Print Print { get; set; }
    }
}