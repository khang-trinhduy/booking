using System.Collections.Generic;
using System.Linq;

namespace BookingForm.Models
{
    public class Stage
    {
        public int Id { get; set; }
        public List<Apartment> Apartment { get; private set; } = new List<Apartment>();
        public List<RCode> RCode { get; private set; } = new List<RCode>();
        public bool IsRunning { get; private set; }
        public Stage(List<Apartment> apartment, List<RCode> rcode)
        {
            Apartment = apartment;
            RCode = rcode;
        }
        public void Start()
        {
            IsRunning = true;
            //TODO generate list of available apartment
            //TODO generate code for client
        }
        public void Stop()
        {
            IsRunning = false;
            //TODO make all reservation invalid
            //TODO make all successful purchased customer invalid
            //TODO make all code invalid
        }
        public bool Contain(string code) => RCode.FirstOrDefault(e => e.Code == code) != null;
        
    }
}