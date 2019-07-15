using System;
using System.Collections.Generic;

namespace BookingForm.Models
{
    public class Storage
    {
        public int Id { get; set; }
        public List<Apartment> Apartments { get; private set; }
        public bool IsOpen { get; private set; }
        public Storage(List<Apartment> apartments, bool isOpen)
        {
            Apartments = apartments;
            IsOpen = isOpen;
        }
        public Storage(){}
        public void Open()
        {
            IsOpen = true;
        }
        public void Close()
        {
            IsOpen = false;
        }
        public bool Contain(Apartment apartment)
        {
            if (Apartments == null)
            {
                return false;
            }
            foreach (var item in Apartments)
            {
                if (apartment.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
        public void Add(Apartment apartment)
        {
            if (Apartments == null)
            {
                Apartments = new List<Apartment>();
            }
            if (Contain(apartment))
            {
                throw new InvalidOperationException("Apartment has already existed!");
            }
            Apartments.Add(apartment);

        }
        
    }
}