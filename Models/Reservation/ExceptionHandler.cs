using System;

namespace BookingForm.Models
{
    public class ExceptionHandler<T> : Exception
    {

        //throw exception
        public ExceptionHandler(string message, Exception innerException) : base(message, innerException)
        {
            
        }

        private static bool ExceptionFilter(Exception e, bool IsDevEnv)
        {
            var expType = e.GetType();
            
            return IsDevEnv;
        }

    }
}