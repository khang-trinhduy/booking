using System.Collections.Generic;
using System.Linq;

namespace BookingForm.Models
{
    public class Batch
    {
        public int Id { get; set; }
        public int BatchNumber { get; set; }
        public Storage Storage { get; set; }
        public List<RCode> RCodes { get; set; }
        public bool IsRunning { get; private set; }
        public Batch()
        {
            
        }
        public Batch(Storage storage, List<RCode> rcode)
        {
            Storage = storage;
            RCodes = rcode;
        }
        public void Start()
        {
            IsRunning = true;
            //TODO generate list of available apartment
            //TODO generate code for client
        }
        public void Stop()
        {
            Storage.Close();
            foreach (var item in RCodes)
            {
                item.Dispose();
            }
            IsRunning = false;
            //TODO make all reservation invalid
            //TODO make all successful purchased customer invalid
            //TODO make all code invalid
        }
        public bool Contain(string code) => RCodes.FirstOrDefault(e => e.Code == code) != null;
        
    }
}