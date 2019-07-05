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
        public override string ToString() => $"-Tên khách hàng: {Reserve.Customer} -Mã căn: {Reserve.ApartmentCode} -Mã xác nhận: {Reserve.RCC}";

        
    }
}