﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem
{
    internal class InvalidSeatCountException : Exception
    {
        public InvalidSeatCountException(string message) : base(message) { }
    }
}
