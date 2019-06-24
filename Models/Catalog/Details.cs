using System.ComponentModel;

namespace BookingForm.Models
{
    public class Details
    {
        public int Id { get; set; }
        [DisplayName("Loại căn hộ")]
        public string DepartmentType { get; set; }
        [DisplayName("Diện tích tim tường")]
        public string AreaIncludeWall { get; set; }
        [DisplayName("Diện tích thông thủy")]
        public string AreaWithoutWall { get; set; }

    }
}