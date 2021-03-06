using System;
using System.Linq;
using System.Collections.Generic;

namespace BookingForm.Models
{
    public class Client
    {
        public int Id { get; set; }
        public String FullName { get; set; }
        public String PhoneNumber { get; set; }
        public String Cmnd { get; set; }
        public int NOProduct { get; set; }
        public bool IsValid { get; set; }
        public List<RCode> Codes {get; set; } = new List<RCode>();

        public bool Contain(RCode code) => Codes != null ? Codes.FirstOrDefault(e => e.Equals(code)) != null : false;
        
    }
}
