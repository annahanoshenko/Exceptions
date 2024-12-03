using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportManager
{
    internal class InvalidTransportException : Exception
    {
        public InvalidTransportException() : base("Error! Other type of transport."){ }

        public InvalidTransportException(string message) : base(message){ }
    }
}
