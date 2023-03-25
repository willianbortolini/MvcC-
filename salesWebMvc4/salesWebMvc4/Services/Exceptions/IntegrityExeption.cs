using System;

namespace salesWebMvc4.Services.Exceptions
{
    public class IntegrityExeption : ApplicationException
    {
        public IntegrityExeption(String message) : base(message) { }
    }
}
