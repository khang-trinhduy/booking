using System.Collections.Generic;
using System.ComponentModel;

namespace BookingForm.Models
{
    public class Floor
    {
        public int Id { get; set; }
        [DisplayName("Tầng")]
        public string Name { get; set; }
        [DisplayName("Ảnh mặt cắt")]
        public string ImagePath { get; set; }
        [DisplayName("Danh sách căn hộ")]
        public List<Apartment> Apartments { get; set; }
        public string CustomField1 { get; set; }
        public string CustomField2 { get; set; }
    }
}