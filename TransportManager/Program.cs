using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TransportManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new InvalidOperationException("Custom message");
            }
            catch (InvalidOperationException ex) when (ex.Message.Contains("Custom"))
            {
                Console.WriteLine("Caught specific InvalidOperationException with 'Custom' in the message.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught a general exception: {ex.Message}");
            }
                Console.ReadKey();

        }
    }
}
