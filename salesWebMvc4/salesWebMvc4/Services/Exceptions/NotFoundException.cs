using System;

namespace salesWebMvc4.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(String message) : base(message) 
        {
        }


    }
}
