using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookingSystem bookingSystem = new BookingSystem(10);
            int[] seats = { 3, 5, -2, 4, 1, 0, 11 };

            foreach (int requests in seats)
            {
                try
                {
                    Console.WriteLine($"Trying to book {requests} seat(s): ");
                    bookingSystem.BookSeats(requests);
                    
                }
                catch (InvalidSeatCountException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (NotEnoughSeatsException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                }
            }
                Console.ReadKey();
        }
    }
}
