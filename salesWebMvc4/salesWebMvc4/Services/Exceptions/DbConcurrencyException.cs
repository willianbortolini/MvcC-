using System;

namespace salesWebMvc4.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(String message) : base(message)
        {
        }
    }
}
