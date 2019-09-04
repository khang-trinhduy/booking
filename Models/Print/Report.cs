using System;
using System.ComponentModel.DataAnnotations;

namespace BookingForm.Models
{
    public class Report
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
    }
}