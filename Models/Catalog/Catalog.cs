using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BookingForm.Models
{
    public class Catalog
    {
        [DisplayName("Chi tiết căn hộ")]
        public Details ApartmentDetails { get; set; }
        [DisplayName("Tầng")]
        public string Floor { get; set; }
        [DisplayName("Hướng")]
        public string Direction { get; set; }
        [DisplayName("Diện tích")]
        public string Area { get; set; }
        [DisplayName("Số phòng ngủ")]
        public string NOBedroom { get; set; }
        [DisplayName("Số phòng vệ sinh")]
        public string NOWC { get; set; }
        [DisplayName("Tên căn hộ")]
        public string Name { get; set; }
        [DisplayName("Khối/Tòa")]
        public string Block { get; set; }
        [DisplayName("View")]
        public string View { get; set; }
        [DisplayName("Mã căn")]
        public string LocalCode { get; set; }
        [DisplayName("Mã căn (từ chủ đầu tư)")]
        public string GlobalCode { get; set; }
        public int Id { get; set; }
    }
}
