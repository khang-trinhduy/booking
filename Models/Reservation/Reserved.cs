using System;
using System.ComponentModel.DataAnnotations;

namespace BookingForm.Models
{
    public class Reserved
    {
        public int Id { get; set; }
        public string Cmnd { get; set; }
        public string PhoneNumber { get; set; }
        public string Customer { get; set; }
        public string ApartmentCode { get; set; }
        public string RCode { get; set; }
        public int CC { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string RCC { get; set; }
    }
}