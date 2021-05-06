using System;
using System.Collections.Generic;
using System.Text;

namespace CarFactory.Domain.Model.Exceptions
{
    public class DuplicateCarException : Exception
    {
        public DuplicateCarException(string message) : base (message)
        {

        }
    }
}
