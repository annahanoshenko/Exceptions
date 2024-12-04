using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonException
{
    internal class PersonException : ArgumentException
    {
        public int Value { get; }
        public PersonException(string message, int value) : base(message) 
        {
            Value = value;
        }
    }
}
