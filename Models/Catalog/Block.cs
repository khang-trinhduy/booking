using System.Collections.Generic;
using System.ComponentModel;

namespace BookingForm.Models
{
    public class Block
    {
        public int Id { get; set; }
        [DisplayName("Tên tòa")]
        public string Name { get; set; }
        [DisplayName("Ảnh mặt cắt")]
        public string ImagePath { get; set; }
        [DisplayName("Vị trí")]
        public string Location { get; set; }
        [DisplayName("Danh sách tầng")]
        public List<Floor> Floors { get; set; }
        public string CustomField1 { get; set; }
        public string CustomField2 { get; set; }
    }
}