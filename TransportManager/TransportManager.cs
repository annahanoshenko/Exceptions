using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace TransportManager
{
    internal class TransportManager
    {
        public void ProcessTransport(string transportType)
        {
            if (string.IsNullOrEmpty(transportType))
            {
                throw new ArgumentNullException(nameof(transportType), "Transport type is null or empty");
            }
            switch (transportType)
            {
                case "Car":
                    Console.WriteLine("Car processed");
                    break;
                case "Plane":
                    Console.WriteLine("Plane processed");
                    break;
                default:
                    throw new InvalidTransportException($"Invalid transptort type: {transportType}");

            }
        }
    }
}
