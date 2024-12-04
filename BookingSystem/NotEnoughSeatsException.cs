using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem
{
    internal class NotEnoughSeatsException : Exception
    {
        public NotEnoughSeatsException(string message) : base(message) { }
    }
}
