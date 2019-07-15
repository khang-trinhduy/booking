using System;
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
        public List<Reserved> Reservations { get; set; }
        public List<Confirmation> Confirmations { get; set; }
        public bool IsRunning { get; private set; }
        public Batch()
        {
            RCodes = new List<RCode>();
            Reservations = new List<Reserved>();
            Confirmations = new List<Confirmation>();
        }
        public Batch(Storage storage, List<RCode> rcode)
        {
            Storage = storage;
            RCodes = rcode;
        }
        public void Start()
        {
            IsRunning = true;
            Storage.Open();
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
        public bool ContainCode(string code) => RCodes != null ? RCodes.FirstOrDefault(e => e.Code == code) != null : false;
        
        public bool ContainApartment(string apartmentCode) => Storage != null ? Storage.Contain(apartmentCode) : false;

        public bool ContainConfirmation(string apartmentCode) => Confirmations != null ? Confirmations.FirstOrDefault(e => e.LocalCode == apartmentCode) != null : false;
        
        public RCode GetCode(string code) => RCodes != null ? RCodes.FirstOrDefault(e => e.Code == code) : null;
        
        public Apartment GetApartment(string apartmentCode) => Storage != null ? Storage.Get(apartmentCode) : null;
        
        public Reserved GetReservation(string rcc) => Reservations != null ? Reservations.FirstOrDefault(e => e.RCC == rcc) : null;
        
        public IEnumerable<Reserved> GetReservations(string apartmentCode) => Reservations != null ? Reservations.Where(e => e.ApartmentCode == apartmentCode) : null;

        public Confirmation GetConfirmation(string apartmentCode) => Confirmations != null ? Confirmations.FirstOrDefault(e => e.LocalCode == apartmentCode) : null;
    }
}