using System.ComponentModel.DataAnnotations;

namespace BookingForm.Models
{
    public class Letter
    {
        [DataType(DataType.Text)]
        [Display(Name = "Họ tên")]
        [Required(ErrorMessage = "Họ tên không được để trống")]
        public string Name { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "SĐT khách hàng")]
        [Required(ErrorMessage = "SĐT không được để trống")]
        public string Phone { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "SĐT sales")]
        [Required(ErrorMessage = "SĐT không được để trống")]
        public string Hotline { get; set; }
        public string Font { get; set; }
        public int Size { get; set; }
        public string Color { get; set; }
    }
}