using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookingForm.Models
{
    public class Print
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Số lượng file không được bỏ trống")]
        [Display(Name="Số lượng file")]
        public int Quantity { get; set; }
        [Display(Name="Tên file")]
        public string FileName { get; set; }
        public string Printer { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name="Ngày in")]
        public DateTime PrintDate { get; set; }
        public string CompanyName { get; set; }
        public string Type { get; set; }
        public List<Download> Files {get; set;}
        public Guid Code { get; set; }
    }
}