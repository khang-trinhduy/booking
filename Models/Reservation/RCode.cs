using System;

namespace BookingForm.Models
{
    public class RCode : IEquatable<RCode>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public bool IsUsed { get; set; }
        public Batch Batch { get; set; }
        public void Dispose()
        {
            IsUsed = true;
        }

        public bool Equals(RCode other)
        {
            if (other == null)
            {
                return false;
            }
            return Id == other.Id && Code == other.Code;
        }
    }
}