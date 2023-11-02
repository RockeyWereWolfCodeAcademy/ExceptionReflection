using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTask.Exceptions
{
    internal class InvalidPhoneFormatException : Exception
    {
        public InvalidPhoneFormatException() { }
        public InvalidPhoneFormatException(string message) : base(message)
        {
            
        }
    }
}
