using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsWork
{
    class InvalidTypeException : Exception
    {
        public InvalidTypeException() { }
        public InvalidTypeException(string message) : base(message) { }
    }
}
