using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem
{
    internal class BookingSystem
    {
        private int availableSeats;

        public BookingSystem(int totalSeats) 
        { 
            availableSeats = totalSeats;
        }

        public void BookSeats(int seatsNumberToBook)
        {
            if (seatsNumberToBook <= 0)
            {
                throw new InvalidSeatCountException($"The number of seats to book must be greater than zero.");
            }
            if (seatsNumberToBook > availableSeats)
            {
                throw new NotEnoughSeatsException($"Not enough seats available. Only {availableSeats} seats are left.");
            }

            availableSeats -= seatsNumberToBook;
            Console.WriteLine($"The number of available seats is: {availableSeats}");
        }
    }
}
