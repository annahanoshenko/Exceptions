using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person person = new Person { Name = "Tom", Age = 17 };
            }
            catch (PersonException e)
            {
                Console.WriteLine($"Error: {e.Message}");
                Console.WriteLine($"Error: {e.Value}");
            }
        }
    }
}
