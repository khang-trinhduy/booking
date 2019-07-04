using System;

namespace BookingForm.Models
{
    public class ReservedViewModel
    {
        public Reserved Reserve { private get; set; }
        public ReservedViewModel(Reserved item)
        {
            Reserve = item;
        }
        public string GetInlineDetails()
        {
            if (Reserve == null)
            {
                throw new NullReferenceException(nameof(Reserved));
            }
            return "-Tên khách hàng: " + Reserve.Customer + " -Mã căn: " + Reserve.ApartmentCode + " -Mã xác nhận: " + Reserve.RCC;
        }
    }
}