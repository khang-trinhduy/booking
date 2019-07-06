using System;

namespace BookingForm.Models
{
    public class ExceptionHandler<T> : Exception
    {

        //throw exception
        public ExceptionHandler(string message, Exception innerException) : base(message, innerException)
        {
        }

        public override string ToString() => $"The system cannot continue because it met the following error {Message}, for more information please send this error to your administrator";

    }
}