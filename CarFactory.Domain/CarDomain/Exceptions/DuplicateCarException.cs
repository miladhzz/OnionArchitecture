using System;

namespace CarFactory.Domain.CarDomain.Exceptions
{
    public class DuplicateCarException : Exception
    {
        public DuplicateCarException(string message) : base (message)
        {

        }
    }
}
