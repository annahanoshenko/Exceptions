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

                TransportManager transportManager = new TransportManager();
                string[] transports = { "Car", "Bike", null, "Plane", "Train" };

                foreach (string transport in transports)
                {
                    try
                    {
                        transportManager.ProcessTransport(transport);
                    }
                    catch (ArgumentNullException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    catch (InvalidTransportException ex)
                    {

                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }

                }
                     Console.ReadKey();
            }
        }
    }

