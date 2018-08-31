using System;

namespace Application.Exceptions
{
    public sealed class InvalidCreateCustomerCommadException : Exception
    {
        private const string domainMessage = "Create Command is not valid"; 
        
        public InvalidCreateCustomerCommadException() : base(domainMessage)
        {
        }
    }
}