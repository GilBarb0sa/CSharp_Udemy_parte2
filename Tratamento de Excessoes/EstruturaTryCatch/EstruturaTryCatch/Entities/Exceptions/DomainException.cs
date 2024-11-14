using System;

namespace EstruturaTryCatch.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) 
        {
        }
    }
}
