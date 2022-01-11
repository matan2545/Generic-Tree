using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsWork
{
    class ValueNotFoundException : Exception
    {
        public ValueNotFoundException() { }
        public ValueNotFoundException(string message) : base(message) { }
    }
}
