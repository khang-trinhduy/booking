using System;

namespace BookingForm.Models
{
    public class InvoiceViewModel
    {
        public string Greeting { get; set; }
        public string Apartment { get; set; }
        public string NORoom { get; set; }
        public string RoomDetails { get; set; }

        public InvoiceViewModel(Invoice invoice)
        {
            if (invoice.Apartment == null || invoice.Client == null)
            {
                throw new NullReferenceException(nameof(Invoice));
            }
            Greeting = CreateGreeting(invoice.Client, invoice.Apartment);
            Apartment = invoice.Apartment.GetName();
            NORoom = invoice.Apartment.GetRoom();
            RoomDetails = invoice.Apartment.GetDetails();
        }

        private string CreateGreeting(Client client, Apartment apartment) => $"Chúc mừng khách hàng {client.FullName} đã đặt mua thành công căn hộ số {apartment.LocalCode}!";

    }
}