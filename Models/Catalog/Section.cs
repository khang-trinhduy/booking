using System.Collections.Generic;
using System.ComponentModel;

namespace BookingForm.Models
{
    public class Section
    {
        public int Id { get; set; }
        [DisplayName("Tên phân khu")]
        public string Name { get; set; }
        [DisplayName("Mã phân khu")]
        public string Code { get; set; }
        [DisplayName("Ảnh mặt cắt")]
        public string ImagePath { get; set; }
        [DisplayName("Vị trí phân khu")]
        public string Location { get; set; }
        [DisplayName("Danh sách tòa")]
        public List<Block> Blocks { get; set; }
        public string CustomField1 { get; set; }
        public string CustomField2 { get; set; }
    }
}